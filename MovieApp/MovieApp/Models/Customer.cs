using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieApp.Models;

namespace MovieApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required()]
        [StringLength(50)]
        [Display(Name="Frist Name")]
        public string FirstName { get; set; }

        [Required()]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [StringLength(15)]
        [Display(Name ="Date of birth")]
        public string BirthDate { get; set; }

        [Display(Name ="Membership type")]
        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}