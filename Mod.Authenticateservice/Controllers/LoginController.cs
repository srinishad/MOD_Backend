using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mod.Authenticateservice.Models;
using Mod.Authenticateservice.Repository;

namespace Mod.Authenticateservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _repository;
        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        [Route("Validate/{Email}/{Password}")]
        public Token Get(string Email, string Password)
        {
            if (_repository.UserLogin(Email, Password)!=null)
            {
                User response = _repository.UserLogin(Email, Password);
                return new Token() { message = "User", token = response.UserId.ToString() };
            }
            else if (_repository.MentorLogin(Email, Password)!=null)
            {
                Mentor response = _repository.MentorLogin(Email, Password);
                return new Token() { message = "Mentor", token =response.MentorId.ToString() };
            }
            else if (Email == "CouseAcadamy" && Password == "admin")
            {
                return new Token() { message = "Admin", token = "Admin" };
            }
            else
            {
                return new Token() { message = "Invalid User", token = "" };
            }

        }

        public string GetToken()
        {
            return  "";
        }
    }
}