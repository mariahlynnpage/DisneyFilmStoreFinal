using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyFilmStore.Models.FilmModels
{
    public class FilmCreate
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Range(1900,9999)]
        public int YearReleased { get; set; }
        [Required]
        public decimal MemberCost { get; set; }
        [Required]
        public decimal NonMemberCost { get; set; }
    }
}
