using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyHomies.Models;

namespace MyHomies.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyHomies.Models.MyHomiesContext _context;

        public IndexModel(MyHomies.Models.MyHomiesContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
