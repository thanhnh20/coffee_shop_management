using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utils
{
    public class AccStaViewModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username")]
        [MinLength(10, ErrorMessage = "Username must be at least 10 characters!")]
        [MaxLength(30, ErrorMessage = "Username must be lesser than or equal to 30 characters!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [Display(Name = "Password")]
        [PasswordPropertyText(true)]
        [MinLength(3, ErrorMessage = "Password must be at least 3 characters")]
        [MaxLength(20, ErrorMessage = "Password must be lesser than or equal to 20 characters!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Role is required!")]
        [Display(Name = "Role Id", Description = "0 - Admin / 1 - Staff")]
        //[Range(minimum: 0, maximum: 1, ErrorMessage = "Role id must be 0 for Admin or 1 for Staff!")]
        [DefaultValue(1)]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Status is required!")]
        [Display(Name = "Status", Description = "0 - inactive / 1 - active")]
        [Range(minimum: 0, maximum: 1, ErrorMessage = "Status must be 0 for Inactive or 1 for Active!")]
        [DefaultValue(1)]
        public int Status { get; set; }
        public int? StaffId { get; set; }

        [Required(ErrorMessage = "Staff Name is required!")]
        [Display(Name = "Staff Name")]
        [MinLength(10, ErrorMessage = "Staff Name must be at least 10 characters!")]
        [MaxLength(30, ErrorMessage = "Staff Name be lesser than or equal to 30 characters!")]
        public string? Fullname { get; set; }

        [Required(ErrorMessage = "Date Join is required!")]
        [Display(Name = "Staff Date Join")]
        public DateTime? DateJoin { get; set; }

        [Display(Name = "Staff Address")]
        [MinLength(10, ErrorMessage = "Staff Address must be at least 10 characters!")]
        [MaxLength(50, ErrorMessage = "Staff Address be lesser than or equal to 50 characters!")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Phone Number is required!")]
        [StringLength(10, ErrorMessage = "Phone number length must be equal to 10!")]
        [DisplayName("Phone Number")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Phone number must start with 0 and contain only numbers!")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Staff Date Join")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Tax Code is required!")]
        [DisplayName("Tax Code")]
        [StringLength(1, ErrorMessage = "Tax Code length must be equal to 1!")]
        public string? TaxCode { get; set; }

        [Required(ErrorMessage = "Salary is required!")]
        [DisplayName("Salary")]
        public double? Salary { get; set; }
    }
}
