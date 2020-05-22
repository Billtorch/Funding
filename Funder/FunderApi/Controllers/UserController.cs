using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Funder.Models;
using Funder.Options;
using Funder.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FunderApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {


        private readonly ILogger<UserController> _logger;
        private readonly IUserManager usrMangr;
        private readonly IProjectManager projMangr;
        //private readonly IBasketManager baskMangr;


        public UserController(ILogger<UserController> logger,
            IUserManager _usrMangr,
            IProjectManager _projMangr
                                   
            )
        {
            _logger = logger;
            usrMangr = _usrMangr;
            projMangr = _projMangr;
            
        }

        [HttpGet("")]
        public string Get()
        {  
            return "Join us!";
        }


        [HttpPost("")]
        public User PostUser(UserOption usrOpt)
        {
            return usrMangr.CreateUser(usrOpt);
        }

        [HttpPut("{id}")]
        public User PutUser(int id, UserOption usrOpt)
        {
            return usrMangr.Update(usrOpt, id);
        }

        [HttpDelete("delete/{id}")]
        public bool HardDeleteUser(int id)
        {
            return usrMangr.DeleteUserById(id);
        }






        // project controller



        [HttpPost("")]
        public Project PostProject(ProjectOption projOpt)
        {
            return projMangr.CreateProject(projOpt);
        }

        [HttpPut("{id}")]
        public Project PutProject(int id, ProjectOption projOpt)
        {
            return projMangr.Update(projOpt, id);
        }

        [HttpDelete("delete/{id}")]
        public bool HardDeleteProject(int id)
        {
            return projMangr.DeleteProjectById(id);
        }


    }
}