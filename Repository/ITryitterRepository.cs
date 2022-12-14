using twitter_vinicius.Models;

namespace twitter_vinicius.Repository;

public interface ITryitterRepository
{
    IEnumerable<StudentDTO> GetStudents();
    StudentDTO GetStudentById(int id);
    StudentDTONew CreateStudent(Student student);
    StudentDTONew UpdateStudent(int studentId, Student student);
    void DeleteStudent(int studentId);
    IEnumerable<PostDTOStudent> GetPosts();
    PostDTOStudent GetPostById(int id);
    PostInsert CreatePost(Post post);
    PostInsert UpdatePost(int postId, Post post);
    void DeletePost(int postId);
}