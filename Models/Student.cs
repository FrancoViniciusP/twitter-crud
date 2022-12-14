namespace twitter_vinicius.Models;
using System.ComponentModel.DataAnnotations;
public class Student
{
    [Key]
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Level { get; set; }
    public string Password { get; set; }
    public ICollection<Post> Posts { get; set; }
}

public class StudentDTO
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Level { get; set; }
    public string Password { get; set; }
    public ICollection<Post> Posts { get; set; }
}

public class StudentDTONew
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Level { get; set; }
    public string Password { get; set; }
}
