namespace SchoolAplication.Models
{
    public class TeacherClass
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
    }
}
