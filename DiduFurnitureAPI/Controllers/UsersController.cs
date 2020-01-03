using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiduFurniture.BLL.Repository;
using DiduFurniture.DAL;
using DiduFurnitureAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiduFurnitureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsers _usersSvc;
        public UsersController(IUsers usersSvc)
        {
            _usersSvc = usersSvc;
        }
        [HttpPost]
        [Route("changeuserpassword")]

        public ActionResult ChangeUserPassword(string username, string pass)
        {
            var res= _usersSvc.changeUserPassword(pass, username);
            if(res)
            {
                return Ok("Password Updated");
            }
            else
            {
                return BadRequest("No Matching Record Found");
            }
        }
        [HttpPost]
        [Route("userlogin")]
        public ActionResult UserLogin(string username, string pass)
        {
          var res=_usersSvc.Login(pass, username);
            if(res)
            {
                return Ok("Login Successful");
            }
            else
            {
                return BadRequest("Invalid UserName or Password");
            }
        }
    }
}