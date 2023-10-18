using Microsoft.EntityFrameworkCore.Design;

public class Student
{
    public int Id {get; set; }
    public string? LastName {get; set; }
    public string? FirstName { get; set; }

    // public Grade Grade {get; set; }
    public List<Enrollment>? Enrollment {get; set; }
}