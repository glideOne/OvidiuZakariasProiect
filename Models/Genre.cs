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
        public string Name { get; set; }
        [Display(Name = "Stylistic Origins")]
        public string Origins { get; set; }
        [Display(Name = "First Year")]
        public int Year { get; set; }
    }
}
