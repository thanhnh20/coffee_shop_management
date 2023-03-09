using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CafeManagement.Services.VModels
{
    public class RoleM
    {
        [Required(ErrorMessage = "Role Id is required!")]
        [Display(Name = "Role Id")]
        public int RoleId { get; set; }
        [Required(ErrorMessage = "Role name is required!")]
        [Display(Name = "Role name")]
        [MaxLength(20, ErrorMessage = "Role name must be lesser than or equal to 20 characters!")]
        [DefaultValue("Anonymous")]
        public string Name { get; set; } = null!;
    }
}
