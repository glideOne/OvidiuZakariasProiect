using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OvidiuZakariasProiect.Models;

namespace OZakariasPr.Data
{
    public class OZakariasPrContext : DbContext
    {
        public OZakariasPrContext (DbContextOptions<OZakariasPrContext> options)
            : base(options)
        {
        }

        public DbSet<OvidiuZakariasProiect.Models.Artist> Artist { get; set; }

        public DbSet<OvidiuZakariasProiect.Models.Album> Album { get; set; }

        public DbSet<OvidiuZakariasProiect.Models.Genre> Genre { get; set; }
    }
}
