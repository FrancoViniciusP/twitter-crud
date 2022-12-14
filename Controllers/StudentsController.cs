using Microsoft.AspNetCore.Mvc;
using twitter_vinicius.Repository;
using twitter_vinicius.Models;

namespace twitter_vinicius.Controllers;

[ApiController]
[Route("students")]
public class StudentsController : Controller
{
    private readonly ITwitterRepository _repository;

    public StudentsController(ITwitterRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var students = _repository.GetStudents();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var student = _repository.GetStudentById(id);
        return Ok(student);
    }

    [HttpPost]
    public IActionResult Post(Student student)
    {
        _repository.CreateStudent(student);
        return Ok(student);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Student student)
    {
        _repository.UpdateStudent(id, student);
        return Ok(student);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _repository.DeleteStudent(id);
        return Ok(new {message = "Estudante deletado com sucesso!"});
    }
}