using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BarberShop_Sukhmanbir.Buss;
using BarberShop_Sukhmanbir.Data;

namespace BarberShop_Sukhmanbir.Pages.Booking
{
    public class CreateModel : PageModel
    {
        private readonly BarberShop_Sukhmanbir.Data.ApplicationDbContext _context;

        public CreateModel(BarberShop_Sukhmanbir.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "Name");
        ViewData["StaffID"] = new SelectList(_context.Staffs, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Buss.Booking Booking { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bookings.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
