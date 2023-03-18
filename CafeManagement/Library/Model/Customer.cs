using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

#nullable disable

namespace Library.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Required(ErrorMessage = "Phone Number is required!")]
        [StringLength(10, ErrorMessage = "Phone number length must be equal to 10!")]
        [DisplayName("Phone Number")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Phone number must start with 0 and contain only numbers!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Customer Name is required!")]
        [Display(Name = "Customer Name")]
        [MinLength(10, ErrorMessage = "Customer Name must be at least 10 characters!")]
        [MaxLength(30, ErrorMessage = "Customer Name be lesser than or equal to 30 characters!")]
        public string Name { get; set; }

        [Display(Name = "Customer Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Customer Email must be a valid email!")]
        public string Email { get; set; }

        [Display(Name = "Customer Address")]
        [MinLength(10, ErrorMessage = "Customer Address must be at least 10 characters!")]
        [MaxLength(50, ErrorMessage = "Customer Address be lesser than or equal to 50 characters!")]
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
