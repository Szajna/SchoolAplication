namespace SchoolAplication.Models
{
    public class StudentClass
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
    }
}
