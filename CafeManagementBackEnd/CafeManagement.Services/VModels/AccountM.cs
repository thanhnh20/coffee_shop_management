using CafeManagement.Infrastructure.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CafeManagement.Services.API.VModels
{
    public class AccountM
    {
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username")]
        [MinLength(10, ErrorMessage = "Username must be at least 10 characters!")]
        [MaxLength(30,ErrorMessage = "Username must be lesser than or equal to 30 characters!")]
        [DefaultValue("username01")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Password is required!")]
        [Display(Name = "Password")]
        [MinLength(3, ErrorMessage = "Password must be at least 3 characters")]
        [MaxLength(20,ErrorMessage = "Password must be lesser than or equal to 20 characters!")]
        [DefaultValue(123)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Confirm Password is required!")]
        [Display(Name = "Confirm Password")]
        [MinLength(3, ErrorMessage = "Confirm Password must be at least 3 characters")]
        [MaxLength(20, ErrorMessage = "Confirm Password must be lesser than or equal to 20 characters!")]
        [DefaultValue(123)]
        [Compare("Password",ErrorMessage = "Confirm Password not Matched with Password!")]
        public string ConfirmPassword { get; set; } = null!;

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
        /*[Required]
        [StringLength(10, ErrorMessage = "Length must be equal to 10!")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Phone number must start with 0 and contain only numbers!")]*/
    }
}
