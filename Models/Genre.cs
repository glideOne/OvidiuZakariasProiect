using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OvidiuZakariasProiect.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Display(Name = "Genre")]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Stylistic Origins")]
        [StringLength(1000)]
        public string Origins { get; set; }
        [Display(Name = "First Year")]
        [Range(1800, 2050, ErrorMessage = "Please enter a year between 1800 and 2050!")]
        public int Year { get; set; }
    }
}
