using System.ComponentModel.DataAnnotations;

namespace Company.PL.Dtos
{
    public class CreateDpartmentDto
    {
        [Required(ErrorMessage ="code is required")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "CreateAt is required")]
        public DateTime CreateAt { get; set; }
    }
}
