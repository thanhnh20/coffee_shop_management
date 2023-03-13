using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Library.Model
{
    public partial class Account
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public int RoleId { get; set; }
        public int Status { get; set; }

        public virtual Role Role { get; set; }
        public virtual staff staff { get; set; }
    }
}
