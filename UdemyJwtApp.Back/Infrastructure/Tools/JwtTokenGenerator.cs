using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UdemyJwtApp.Back.Core.Application.Dto;

namespace UdemyJwtApp.Back.Infrastructure.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseDto GenerateToken(CheckUserResponseDto dto)
        {
            var claims = new List<Claim>();

<<<<<<< HEAD
<<<<<<< HEAD
            if (!string.IsNullOrEmpty(dto.Role))
                claims.Add(new Claim(ClaimTypes.Role, dto.Role));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString()));
            if (!string.IsNullOrEmpty(dto.Username))
                claims.Add(new Claim("Username", dto.Username));

            var securitKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
            SigningCredentials credentials = new SigningCredentials(securitKey, SecurityAlgorithms.HmacSha256);

            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Experie);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: JwtTokenDefaults.ValidIssuer, audience: JwtTokenDefaults.ValidAudience, claims: claims, notBefore: DateTime.UtcNow, expires: expireDate, signingCredentials: credentials);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return new TokenResponseDto(handler.WriteToken(jwtSecurityToken), expireDate);
=======
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            if(!string.IsNullOrEmpty(dto.Role))
           claims.Add(new Claim(ClaimTypes.Role, dto.Role)) ;   
           claims.Add(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString())) ;
            if (!string.IsNullOrEmpty(dto.Username))
                claims.Add(new Claim("Username", dto.Username));   

            var securitKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
            SigningCredentials credentials = new SigningCredentials(securitKey,SecurityAlgorithms.HmacSha256);

            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Experie);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer:JwtTokenDefaults.ValidIssuer,audience:JwtTokenDefaults.ValidAudience,claims:claims,notBefore:DateTime.UtcNow,expires:expireDate,signingCredentials:credentials);
            JwtSecurityTokenHandler handler= new JwtSecurityTokenHandler();
           
            return new TokenResponseDto(handler.WriteToken(jwtSecurityToken),expireDate);
<<<<<<< HEAD
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
    }
}
