public class Course
{
    public int CourseId { get; set; }
    public string? Title { get; set; }
    public int Credits { get; set; }

    public List<Enrollment>? Enrollment { get; set; }
}