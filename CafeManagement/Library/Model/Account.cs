using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Library.Model
{
    public partial class Account
    {
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username")]
        [MinLength(5, ErrorMessage = "Username must be at least 5 characters!")]
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
        public int Status { get; set; }

        public virtual Role Role { get; set; }
        public virtual staff staff { get; set; }
    }
}
