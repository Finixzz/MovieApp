﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieApp.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(11)]
        public string BirthDate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}