using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using UdemyJwtApp.Front.Models;

namespace UdemyJwtApp.Front.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Login()
        {
            return View(new UserLoginModel());
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginModel model)
        {
<<<<<<< HEAD
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();

                var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5280/api/Auth/Login", content);
=======
            if(ModelState.IsValid)
            {
             var client= _httpClientFactory.CreateClient();

                var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
              var response= await client.PostAsync("http://localhost:5280/api/Auth/Login",content);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var tokenModel = JsonSerializer.Deserialize<JwtTokenResponseModel>(jsonData, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
<<<<<<< HEAD
                    });
                    if (tokenModel != null)
                    {
                        JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                        var token = handler.ReadJwtToken(tokenModel.Token);

                        var claims = token.Claims.ToList();

                        if (tokenModel.Token != null)
                            claims.Add(new Claim("accesToken", tokenModel.Token));

                        var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
=======
                    }); 
                    if(tokenModel != null)
                    {
                        JwtSecurityTokenHandler handler= new JwtSecurityTokenHandler();
                        var token=handler.ReadJwtToken(tokenModel.Token);

                        var claims = token.Claims.ToList();

                        if(tokenModel.Token!=null)
                        claims.Add(new Claim("accesToken",tokenModel.Token));

                    var claimsIdentity = new ClaimsIdentity(claims,JwtBearerDefaults.AuthenticationScheme);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24

                        var autProps = new AuthenticationProperties
                        {
                            ExpiresUtc = tokenModel.ExpireDate,
                            IsPersistent = true,
                        };

<<<<<<< HEAD
                        await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), autProps);
=======
                     await   HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), autProps);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
                        return RedirectToAction("Index", "Home");

                    }

<<<<<<< HEAD

=======
                    
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
                }
                else
                {
                    ModelState.AddModelError("", "kullanıcı adı veya şifre hatalı");
                }
<<<<<<< HEAD

=======
                
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            }
            return View(model);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
