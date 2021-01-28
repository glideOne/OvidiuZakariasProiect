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
        [StringLength(255)]
        public string StageName { get; set; }
        [Display(Name = "Real Name / Lineup")]
        [StringLength(255)]
        [RegularExpression("[a-zA-Z\\s-,]+", ErrorMessage = "Name can only contain letters and '-', separated by ','")]
        public string RealName { get; set; }
        [Display(Name = "Date of first release")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}
