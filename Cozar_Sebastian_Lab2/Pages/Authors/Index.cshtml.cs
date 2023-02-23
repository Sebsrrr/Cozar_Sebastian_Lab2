using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cozar_Sebastian_Lab2.Data;
using Cozar_Sebastian_Lab2.Models;

namespace Cozar_Sebastian_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Cozar_Sebastian_Lab2.Data.Cozar_Sebastian_Lab2Context _context;

        public IndexModel(Cozar_Sebastian_Lab2.Data.Cozar_Sebastian_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}
