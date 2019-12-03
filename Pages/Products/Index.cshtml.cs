using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductsWork.Data;
using ProductsWork.Models;

namespace ProductsWork.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductsWork.Data.ProductsContext _context;

        public IndexModel(ProductsWork.Data.ProductsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
