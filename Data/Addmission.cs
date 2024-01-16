using System.ComponentModel.DataAnnotations;

namespace TermProject.Data
{
    public class Addmission
    {
        [key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

       
        public int Age { get; set; }
        
    }
}
