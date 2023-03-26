using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CandidateModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;
        public string? EmailAdress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ZipCode { get; set; }
    }
}
