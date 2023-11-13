using System.ComponentModel.DataAnnotations;

namespace GarratonITELEC1C.Models
{
    public enum Rank
    {
        Instructor,AssistantProfessor,AssociateProfessor,Professor
    }

    public class Instructor
    {

        [Required(ErrorMessage = "ID is required")]
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "First Name")]
        
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status is required")]
        public bool IsTenured { get; set; }
        [Display(Name = "Hiring Date")]

        public DateTime HiringDate { get; set; }
        [Display(Name = "Rankkkkkkkkkk")]
        [Required(ErrorMessage = "Rank is required")]
        public Rank Rank { get; set; }

    }
}
