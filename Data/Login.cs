using System.ComponentModel.DataAnnotations;
namespace TermProject.Data
{
    public class Login
    {
        [key]
        public int Id { get; set; }
        public string Username { get; set;}
        public string Password { get; set;}
        
    }
}
