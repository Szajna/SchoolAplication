using Microsoft.AspNetCore.Identity;

namespace SchoolAplication.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
