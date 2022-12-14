namespace twitter_vinicius.Repository;

public interface ILoginRepositor
{
    Task<string> GenerateToken(string email, string password);
}