using twitter_vinicius.Models;
using Microsoft.EntityFrameworkCore;

namespace twitter_vinicius.Repository;

public class TryitterRepository : ITwitterRepository
{
    protected readonly TryitterContext _context;

    public TryitterRepository(TryitterContext context)
    {
        _context = context;
    }
    
    public IEnumerable<StudentDTO> GetStudents()
    {
        return _context.Students.Select(s => new StudentDTO
        {
            StudentId = s.StudentId,
            Name = s.Name,
            Email = s.Email,
            Level = s.Level,
            Posts = s.Posts.Select(p => new PostDTO
            {
                Text = p.Text,
            }).ToList()
        }).ToList();
    }
    
    public StudentDTO GetStudentById(int id)
    {
        return _context.Students.Where(s => s.StudentId == id).Select(s => new StudentDTO
        {
            StudentId = s.StudentId,
            Name = s.Name,
            Email = s.Email,
            Level = s.Level,
            Posts = s.Posts.Select(p => new PostDTO
            {
                Text = p.Text,
            }).ToList()
        }).First();
    }
    
    public StudentDTONew CreateStudent(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
        
        return new StudentDTONew { Name = student.Name,
            Password = student.Password,
            Email = student.Email,
            Level = student.Level };
    }
    
    public StudentDTONew UpdateStudent(int studentId, Student student)
    {
        var studentToUpdate = _context.Students.Find(studentId);
        if (studentToUpdate != null)
        {
            studentToUpdate.Name = student.Name;
            studentToUpdate.Email = student.Email;
            studentToUpdate.Level = student.Level;
            studentToUpdate.Password = student.Password;
        }

        _context.SaveChanges();
        
        return new StudentDTONew { StudentId = student.StudentId,
            Name = student.Name,
            Password = student.Password,
            Email = student.Email,
            Level = student.Level };
    }
    
    public void DeleteStudent(int studentId)
    {
        var studentToDelete = _context.Students.Find(studentId);
        if (studentToDelete == null) return;
        _context.Students.Remove(studentToDelete);
        _context.SaveChanges();
    }
    
    public IEnumerable<PostDTOStudent> GetPosts()
    {
        return _context.Posts.Select(p => new PostDTOStudent
        {
            PostId = p.PostId,
            Text = p.Text,
            StudentName = p.Student.Name,
        }).ToList();
    }
    
    public PostDTOStudent GetPostById(int id)
    {
        return _context.Posts.Where(p => p.PostId == id)
            .Select(p => new PostDTOStudent
            {
                PostId = p.PostId,
                Text = p.Text,
                StudentName = p.Student.Name,
            }).First();
    }
    
    public PostInsert CreatePost(Post post)
    {
        _context.Posts.Add(post);
        _context.SaveChanges();
        
        return new PostInsert { PostId = post.PostId,
            Text = post.Text,
            StudentId = post.StudentId };
    }
    
    public PostInsert UpdatePost(int postId, Post post)
    {
        var postToUpdate = _context.Posts.Find(postId);
        if (postToUpdate != null)
        {
            postToUpdate.Text = post.Text;
            postToUpdate.StudentId = post.StudentId;
        }

        _context.SaveChanges();
        
        return new PostInsert { PostId = post.PostId,
            Text = post.Text,
            StudentId = post.StudentId };
    }
    
    public void DeletePost(int postId)
    {
        var postToDelete = _context.Posts.Find(postId);
        if (postToDelete == null) return;
        _context.Posts.Remove(postToDelete);
        _context.SaveChanges();
    }

}