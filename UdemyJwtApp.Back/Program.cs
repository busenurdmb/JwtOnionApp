using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using System.Security.Cryptography;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
using System.Security.Cryptography;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
using System.Text;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Application.Mappings;
using UdemyJwtApp.Back.Infrastructure.Tools;
using UdemyJwtApp.Back.Persistance.Context;
using UdemyJwtApp.Back.Persistance.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidAudience = JwtTokenDefaults.ValidAudience,
        ValidIssuer = JwtTokenDefaults.ValidIssuer,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
<<<<<<< HEAD
<<<<<<< HEAD
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
=======
        ValidateIssuerSigningKey=true,
        ValidateLifetime=true,
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
        ValidateIssuerSigningKey=true,
        ValidateLifetime=true,
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24

    };
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UdemyJwtContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Local"));
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfiles(new List<Profile>()
    {
        new ProductProfile(),
        new CategoryProfile(),
<<<<<<< HEAD
<<<<<<< HEAD
    });
=======
    }) ;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
    }) ;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();