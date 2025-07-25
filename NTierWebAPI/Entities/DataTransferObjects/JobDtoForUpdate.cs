using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects 
{
    public class JobDtoForUpdate
    {
        [Required(ErrorMessage = "The field 'JobTitle' is required!!!")]
        [StringLength(20, ErrorMessage = "'JobTitle' cannot be longer than 20 characters.")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "The field 'DepartmentID' is required!!!")]
        public int? DepartmentID { get; set; }
    }
}