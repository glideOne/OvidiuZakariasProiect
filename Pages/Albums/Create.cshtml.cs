﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OZakariasPr.Data;
using OvidiuZakariasProiect.Models;

namespace OvidiuZakariasProiect.Pages.Albums
{
    public class CreateModel : PageModel
    {
        private readonly OZakariasPr.Data.OZakariasPrContext _context;

        public CreateModel(OZakariasPr.Data.OZakariasPrContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ArtistId"] = new SelectList(_context.Set<Artist>(), "Id", "StageName");
            ViewData["GenreId"] = new SelectList(_context.Set<Genre>(), "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Album Album { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Album.Add(Album);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
