using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OvidiuZakariasProiect.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Display(Name = "Stage Name (Alias)")]
        public string StageName { get; set; }
        [Display(Name = "Real Name")]
        public string RealName { get; set; }
        [Display(Name = "Date of first release")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}
