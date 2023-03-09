using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CafeManagement.Services.VModels
{
    public class AccountVM
    {
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username")]
        [MinLength(10, ErrorMessage = "Username must be at least 10 characters!")]
        [MaxLength(30, ErrorMessage = "Username must be lesser than or equal to 30 characters!")]
        [DefaultValue("username01")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Password is required!")]
        [Display(Name = "Password")]
        [MinLength(3, ErrorMessage = "Password must be at least 3 characters")]
        [MaxLength(20, ErrorMessage = "Password must be lesser than or equal to 20 characters!")]
        [DefaultValue(123)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Role is required!")]
        [Display(Name = "Role Id", Description = "0 - Admin / 1 - Staff")]
        [DefaultValue(1)]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Status is required!")]
        [Display(Name = "Status", Description = "0 - inactive / 1 - active")]
        [Range(minimum: 0, maximum: 1, ErrorMessage = "Status must be 0 for Inactive or 1 for Active")]
        [DefaultValue(1)]
        public int Status { get; set; }
    }
}
