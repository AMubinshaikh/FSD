using System;
using System.ComponentModel.DataAnnotations;

namespace fsd16.Resources {
    public class CreateCustomerResource {
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
    }
}