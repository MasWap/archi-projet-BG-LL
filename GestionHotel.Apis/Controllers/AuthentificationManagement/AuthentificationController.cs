using GestionHotel.Apis.Domain.Authentification;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GestionHotel.Apis.Controllers.AuthentificationManagement
{
	public class AuthentificationController : ControllerBase
	{
		[HttpPost("login")]
		public IActionResult Login([FromBody] Authentification model)
		{
			// Vérifiez les informations d'identification de l'utilisateur
			if (!ValidateUser(model.Username, model.Password))
			{
				return Unauthorized();
			}

			// Générez un jeton JWT
			var claims = new[]
			{
				new Claim(ClaimTypes.Name, model.Username),
				new Claim(ClaimTypes.Role, "Admin")
			};

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("iUBadurEM9JbL3dtjyGkUqeVjZeqT1G9"));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
				"GestionHotel.Apis",
				"GestionHotel.Apis",
				claims,
				expires: DateTime.Now.AddMinutes(30),
				signingCredentials: creds);

			return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
		}

		private bool ValidateUser(string username, string password)
		{
			return username == "john_doe" && password == "s3cr3t_p4ssw0rd";
		}
	}
}
