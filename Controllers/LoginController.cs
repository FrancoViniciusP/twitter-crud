using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using twitter_vinicius.Models;
using twitter_vinicius.Repository;

namespace twitter_vinicius.Controllers;

[ApiController]
[Route("login")]
public class LoginController : Controller
{
    private readonly ILoginRepositor _repository;

    public LoginController(ILoginRepositor repository)
    {
        _repository = repository;
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Login([FromBody] Login login)
    {
        var token = await _repository.GenerateToken(login.Email, login.Password);

        if (string.IsNullOrEmpty(token))
        {
            return Unauthorized("Usuário ou senha inválidos");
        }

        return Ok(token);
    }
}