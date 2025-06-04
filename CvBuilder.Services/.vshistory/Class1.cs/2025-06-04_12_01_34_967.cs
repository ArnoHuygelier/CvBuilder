using System.ComponentModel.DataAnnotations;

namespace CvBuilder.Services
{
    public class Class1
    {
        [Required(ErrorMessage = "Full name is required")]
        public required string FullName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Bio is required")]
        public required string Bio { get; set; }
    }
}
