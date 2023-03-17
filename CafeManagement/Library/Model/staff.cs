﻿using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
=======
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b

#nullable disable

namespace Library.Model
{
    public partial class staff
    {
        public staff()
        {
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }

<<<<<<< HEAD
        [Required(ErrorMessage = "Full Name is required!")]
        [Display(Name = "Full Name")]
        [MinLength(10, ErrorMessage = "Full Name must be at least 10 characters!")]
        [MaxLength(50, ErrorMessage = "Full Name must be lesser than or equal to 50 characters!")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Date Join is required!")]
        [Display(Name = "Date Join")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateJoin { get; set; }

        [Required(ErrorMessage = "Address is required!")]
        [Display(Name = "Address")]
        [MinLength(10, ErrorMessage = "Address must be at least 10 characters!")]
        [MaxLength(50, ErrorMessage = "Address must be lesser than or equal to 50 characters!")]
=======
        [Required(ErrorMessage = "Staff Name is required!")]
        [Display(Name = "Staff Name")]
        [MinLength(10, ErrorMessage = "Staff Name must be at least 10 characters!")]
        [MaxLength(30, ErrorMessage = "Staff Name be lesser than or equal to 30 characters!")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Date Join is required!")]
        [Display(Name = "Staff Date Join")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateJoin { get; set; }

        [Display(Name = "Staff Address")]
        [MinLength(10, ErrorMessage = "Staff Address must be at least 10 characters!")]
        [MaxLength(50, ErrorMessage = "Staff Address be lesser than or equal to 50 characters!")]
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone Number is required!")]
        [StringLength(10, ErrorMessage = "Phone number length must be equal to 10!")]
        [DisplayName("Phone Number")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Phone number must start with 0 and contain only numbers!")]
<<<<<<< HEAD
        [DefaultValue("0123456789")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Date Of Birth is required!")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Tax Code is required!")]
        public string TaxCode { get; set; }

        [Required(ErrorMessage = "Salary is required!")]
        public double? Salary { get; set; }

=======
        public string PhoneNumber { get; set; }

        [Display(Name = "Staff Date Join")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Tax Code is required!")]
        [DisplayName("Tax Code")]
        [StringLength(1, ErrorMessage = "Tax Code length must be equal to 1!")]
        public string TaxCode { get; set; }

        [Required(ErrorMessage = "Salary is required!")]
        [DisplayName("Salary")]
        public double? Salary { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username")]
        [MinLength(10, ErrorMessage = "Username must be at least 10 characters!")]
        [MaxLength(30, ErrorMessage = "Username must be lesser than or equal to 30 characters!")]
>>>>>>> 796617b80527656193a787505ec464c5228c8b8b
        public string Username { get; set; }

        public virtual Account UsernameNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
