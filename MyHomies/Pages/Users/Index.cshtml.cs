
using System.Collections.Generic;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyHomies.Models;

namespace MyHomies.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly MyHomies.Models.MyHomiesContext _context;

        public IndexModel(MyHomies.Models.MyHomiesContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
