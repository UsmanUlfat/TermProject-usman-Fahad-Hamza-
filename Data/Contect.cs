using System.ComponentModel.DataAnnotations;
namespace TermProject.Data
{
    public class Contect
    {
        [key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

       
      
    }
}
