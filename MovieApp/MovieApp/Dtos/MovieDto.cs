using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Movie name")]
        public string Name { get; set; }

        [Display(Name = "Date of release")]
        public string ReleaseDate { get; set; }

        public string DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public short StockNumber { get; set; }

        [Required]
        public int GenreId { get; set; }

    }
}