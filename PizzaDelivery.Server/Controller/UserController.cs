﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PizzaDelivery.Server.Data;
using PizzaDelivery.Server.DTO;
using PizzaDelivery.Server.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PizzaDelivery.Server.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = new User
            {
                user_name = registerDTO.user_name,
                email = registerDTO.email,
                password = BCrypt.Net.BCrypt.HashPassword(registerDTO.password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(new { Message = "User registered successfully" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.email == loginDTO.email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDTO.password, user.password))
            {
                return Unauthorized(new { Message = "Invalid email or password" });
            }

            var token = GenerateJwtToken(user);
            return Ok(new
            {
                Message = "Login successful",
                Token = token,
                User = new
                {
                    Username = user.user_name,
                    user_id = user.user_id
                }
            });
        }


        private string GenerateJwtToken(User user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("fq/L/r3qRdfA6mzOOflrwmSjo2+7ChpkTcom6NaQYn8="));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.email),
                new Claim("user_id", user.user_id.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: "PizzaDeliveryAPI",
                audience: "PizzaDeliveryWebApp",
                claims: new[] { new Claim(JwtRegisteredClaimNames.Sub, user.email) },
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
