using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using twitter_vinicius.Repository;
using twitter_vinicius.Models;

namespace twitter_vinicius.Controllers;

[ApiController]
[Route("students")]
public class StudentsController : Controller
{
    private readonly ITryitterRepository _repository;

    public StudentsController(ITryitterRepository repository)
    {
        _repository = repository;
    }

    [Authorize]
    [HttpGet]
    public IActionResult Get()
    {
        var students = _repository.GetStudents();
        return Ok(students);
    }

    [Authorize]
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var student = _repository.GetStudentById(id);
        return Ok(student);
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Post(Student student)
    {
        _repository.CreateStudent(student);
        return Ok(student);
    }

    [Authorize]
    [HttpPut("{id}")]
    public IActionResult Put(int id, Student student)
    {
        _repository.UpdateStudent(id, student);
        return Ok(student);
    }

    [Authorize]
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _repository.DeleteStudent(id);
        return Ok(new {message = "Estudante deletado com sucesso!"});
    }
}