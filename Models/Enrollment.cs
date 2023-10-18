public class Enrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int courseId { get; set; }
    public char Grade { get; set; }
    public DateTime EnrollmentDate {get; set; }
    public Student? Student {get; set; }
    public Course? Course {get; set; }
}