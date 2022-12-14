using Microsoft.EntityFrameworkCore;
using twitter_vinicius.Token;

namespace twitter_vinicius.Repository;

public class LoginRepository : ILoginRepositor
{ 
    protected readonly TryitterContext _context;

    public LoginRepository(TryitterContext context)
    {
        _context = context;
    }

    public async Task<string> GenerateToken(string email, string password)
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(x => x.Email == email
                                      && x.Password == password);
        
        return student == null ? null! : new TokenGenerator().Generate(student.StudentId);
    }
  
}