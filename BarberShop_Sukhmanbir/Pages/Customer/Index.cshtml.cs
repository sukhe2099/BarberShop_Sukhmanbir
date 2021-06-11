using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BarberShop_Sukhmanbir.Buss;
using BarberShop_Sukhmanbir.Data;

namespace BarberShop_Sukhmanbir.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly BarberShop_Sukhmanbir.Data.ApplicationDbContext _context;

        public IndexModel(BarberShop_Sukhmanbir.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Buss.Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
