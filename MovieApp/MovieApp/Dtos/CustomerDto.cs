
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required()]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required()]
        [StringLength(50)]
        public string LastName { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [StringLength(15)]
        public string BirthDate { get; set; }

        public int MembershipTypeId { get; set; }
        
    }
}