namespace UdemyJwtApp.Back.Infrastructure.Tools
{
    public class JwtTokenDefaults
    {
        /*   ValidAudience = "htttp://localhost",
        ValidIssuer = "htttp://localhost",
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Busembusembusem1.")),
        ValidateIssuerSigningKey=true,
        ValidateLifetime=true, */

        public const string ValidAudience = "htttp://localhost";
        public const string ValidIssuer = "htttp://localhost";
        public const string Key = "Busembusembusem1.";
        public const int Experie = 5;

    }
}
