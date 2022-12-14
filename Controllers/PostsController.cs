using Microsoft.AspNetCore.Mvc;
using twitter_vinicius.Repository;
using twitter_vinicius.Models;

namespace twitter_vinicius.Controllers;

[ApiController]
[Route("posts")]
public class PostsController: Controller
{
    private readonly ITwitterRepository _repository;

    public PostsController(ITwitterRepository repository)
    {
        _repository = repository;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repository.GetPosts());
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_repository.GetPostById(id));
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] Post post)
    {
        _repository.CreatePost(post);
        return Ok();
    }
    
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Post post)
    {
        _repository.UpdatePost(id, post);
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _repository.DeletePost(id);
        return Ok();
    }
}