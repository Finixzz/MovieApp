using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [StringLength(25)]
        public String Name { get; set; }
    }
}