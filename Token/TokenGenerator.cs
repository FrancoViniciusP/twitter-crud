using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace twitter_vinicius.Token;

public class TokenGenerator
{
    public string Generate(int id)
    {
        var tokenHandler = new JwtSecurityTokenHandler();

        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = AddClaims(id),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes("chave-secreta")),
                SecurityAlgorithms.HmacSha256Signature
            ),
            Expires = DateTime.Now.AddDays(30)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }

    public ClaimsIdentity AddClaims(int id)
    {
        var claims = new ClaimsIdentity();

        claims.AddClaim(new Claim("Id", id.ToString()));

        return claims;
    }
}