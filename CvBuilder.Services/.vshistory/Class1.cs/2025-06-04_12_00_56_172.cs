using System.ComponentModel.DataAnnotations;

namespace CvBuilder.Services
{
    public class Class1
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Bio { get; set; }
    }
}
