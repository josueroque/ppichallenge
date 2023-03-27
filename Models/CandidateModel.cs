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

        [Display(Name = "Email Adress")]
        public string EmailAdress { get; set; } = string.Empty;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Display(Name = "Residential Zip Code")]
        public string ZipCode { get; set; } = string.Empty;
    }
}
