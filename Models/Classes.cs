namespace SchoolAplication.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public ClassType ClassType { get; set; }
    }

    public enum ClassType
    {
        Ogólnokształcący,
        Kierunkowy
    }
}
