using Blog.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Blog.Services
{
    public class TokenService
    {
        public string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler(); //utilizado para gerar o token
            var key = Encoding.ASCII.GetBytes(Configuration.JwtKey); //Precisa transformar a key em bytes para gerar o token
            var tokenDescriptor = new SecurityTokenDescriptor //Especificao do token
            { 
                Subject = new ClaimsIdentity(new Claim[]
                { 
                    new Claim(ClaimTypes.Name, "renanteste"),
                    new Claim(ClaimTypes.Role, "admin"),
                    new Claim(ClaimTypes.Role, "user"),
                    new Claim("fruta", "banana")
                }),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature) //A forma que vai encriptar e desencriptar token e qual o algoritmo que vai ser utilizado
            }; 
            var token = tokenHandler.CreateToken(tokenDescriptor); //Criou o token com base na especificação
            return tokenHandler.WriteToken(token);
        }
    }
}
