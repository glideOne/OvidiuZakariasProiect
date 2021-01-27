﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly OZakariasPr.Data.OZakariasPrContext _context;

        public DetailsModel(OZakariasPr.Data.OZakariasPrContext context)
        {
            _context = context;
        }

        public Album Album { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Album = await _context.Album.FirstOrDefaultAsync(m => m.Id == id);

            if (Album == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}