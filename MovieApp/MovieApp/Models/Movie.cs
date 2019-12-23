using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MovieApp.Models;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Movie name")]
        public string Name { get; set; }

        [Display(Name = "Date of release")]
        public string ReleaseDate { get; set; }

        public string DateAdded { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name = "Number in stock")]
        public short StockNumber { get; set; }

        [Required]
        [Display(Name="Genre")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}