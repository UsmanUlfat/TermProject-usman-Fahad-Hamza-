using System.ComponentModel.DataAnnotations;
namespace TermProject.Data
{
    public class SignUp
    {
        [key]
        public int SignUpId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

      
    }
}
