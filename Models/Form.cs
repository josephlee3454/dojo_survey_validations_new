
using System.ComponentModel.DataAnnotations;
namespace freshs.Models
{
    
    public class Form
    {

        [Required]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters!")]
        public string Name {get; set;}
        
        [Required]
        [MinLength(2, ErrorMessage="Last Name must be at least 2 characters!")]
  
        public string Locations {get; set;}
        
        
        [Required(ErrorMessage="you need the bro come on ")]
  
        public string Languages {get; set;}

        [Required]
        [MinLength(8, ErrorMessage="please leave a comment that is at least 8 characters")]
        public string Comments {get; set;}
               public Form(string name, string lang, string place, string msg)
        {
            Name = name;
            Locations = lang;
            Languages = place;
            Comments = msg;
        }
    }
}
