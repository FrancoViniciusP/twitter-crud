using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace twitter_vinicius.Models;
public class Post
{
    [Key]
    public int PostId { get; set; }
    public string Text { get; set; } = null!;
    [ForeignKey("StudentId")]
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
}