using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OvidiuZakariasProiect.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Release Date")]        
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
