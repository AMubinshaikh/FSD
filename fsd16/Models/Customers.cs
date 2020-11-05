using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fsd16.Models {
    public partial class Customers {
        public Customers () {
            Orders = new HashSet<Orders> ();
        }
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
        public string City { get; set; }

        [Required]
        public string State { get; set; }
        public int Points { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}