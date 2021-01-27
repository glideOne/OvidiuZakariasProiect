using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OZakariasPr.Data;
using OvidiuZakariasProiect.Models;

namespace OvidiuZakariasProiect.Pages.Albums
{
    public class IndexModel : PageModel
    {
        private readonly OZakariasPr.Data.OZakariasPrContext _context;

        public IndexModel(OZakariasPr.Data.OZakariasPrContext context)
        {
            _context = context;
        }

        public IList<Album> Album { get;set; }

        public async Task OnGetAsync()
        {
            Album = await _context.Album
                .Include(a => a.Artist)
                .Include(a => a.Genre)
                .ToListAsync();
        }
    }
}
