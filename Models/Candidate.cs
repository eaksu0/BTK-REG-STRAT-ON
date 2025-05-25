using System.ComponentModel.DataAnnotations;

namespace BTKAKADEMI.Models
{
    public class Candidate 
    {
        [Required(ErrorMessage = "E-mail is required.")]
        public string? Email { get; set; }=String.Empty;
        [Required(ErrorMessage = "First Name is required.")]
        public string? firstName { get; set; }=String.Empty;
        [Required(ErrorMessage = "Last Name is required.")]
        public string? lastName { get; set; }=String.Empty;
        public string? fullName=>$"{firstName} {lastName?.ToUpper()}";

        public int Age { get; set; } = 0;
        public string? selectedCourse { get; set; }=String.Empty;

        public DateTime applyAt { get; set; }=DateTime.Now;

      
    }
}