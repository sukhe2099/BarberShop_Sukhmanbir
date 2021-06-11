﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BarberShop_Sukhmanbir.Buss;
using BarberShop_Sukhmanbir.Data;

namespace BarberShop_Sukhmanbir.Pages.Booking
{
    public class DetailsModel : PageModel
    {
        private readonly BarberShop_Sukhmanbir.Data.ApplicationDbContext _context;

        public DetailsModel(BarberShop_Sukhmanbir.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Buss.Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Bookings
                .Include(b => b.Customer).FirstOrDefaultAsync(m => m.ID == id);

            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
