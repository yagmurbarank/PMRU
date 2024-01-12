using PMRU.BlazorUI.Services.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMRU.BlazorUI.Models
{
    public class EmployeeVM
    {
        [Display(Name = "T.C. Kimlik No")]
        public string IdentityNumber { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "Sicil No")]
        public string RegistrationNumber { get; set; }
        
        public DepartmentVM Department { get; set; }
        
        [Required]
        public LocationVM Location { get; set; }
        
        public PositionVM Position { get; set; }
    }
}
