using Funder.Models;
using Funder.Options;
using Funder.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FunderMVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {


        private readonly ILogger<UserController> _logger;
        private readonly IUserManager usrMangr;
        private readonly IProjectManager projMangr;
        private readonly IRewardManager rewMangr;
        private readonly IFundManager fndMangr;
        private readonly IMediaManager medMangr;


        public UserController(ILogger<UserController> logger,
            IUserManager _usrMangr,
            IProjectManager _projMangr,
            IRewardManager _rewMangr,
            IFundManager _fndMangr,
            IMediaManager _medMangr
            )
        {
            _logger = logger;
            usrMangr = _usrMangr;
            projMangr = _projMangr;
            rewMangr = _rewMangr;
            fndMangr = _fndMangr;
            medMangr = _medMangr;

        }

        [HttpGet("")]
        public string Get()
        {
            return "Join us!";
        }


        [HttpPost("")]
        public User PostUser([FromBody]UserOption usrOpt)
        {
            return usrMangr.CreateUser(usrOpt);
        }

        [HttpPut("{id}")]
        public User PutUser(int id, [FromBody]UserOption usrOpt)
        {
            return usrMangr.Update(usrOpt, id);
        }

        [HttpDelete("delete/{id}")]
        public bool HardDeleteUser(int id)
        {
            return usrMangr.DeleteUserById(id);
        }






        // project controller


        [HttpGet("CreateProject")]
        public IActionResult CreateProject()
        {
            return View();
        }

        [HttpPost("project")]
        public Project PostProject([FromBody]ProjectOption projOpt)
        {
            return projMangr.CreateProject(projOpt);
        }

        [HttpPut("project/{id}")]
        public Project PutProject(int id, [FromBody]ProjectOption projOpt)
        {
            return projMangr.Update(projOpt, id);
        }

        [HttpDelete("project/delete/{id}")]
        public bool HardDeleteProject(int id)
        {
            return projMangr.DeleteProjectById(id);
        }







        // reward controller


        [HttpPost("reward")]
        public Reward PostReward([FromBody]RewardOption rewOpt)
        {
            return rewMangr.CreateReward(rewOpt);
        }

        [HttpPut("reward/{id}")]
        public Reward PutReward(int id, [FromBody]RewardOption rewOpt)
        {
            return rewMangr.Update(rewOpt, id);
        }

        [HttpDelete("reward/delete/{id}")]
        public bool HardDeleteReward(int id)
        {
            return rewMangr.DeleteRewardById(id);
        }





        //fund controller


        [HttpPost("fund")]
        public Fund PostFund([FromBody]FundOption fndOpt)
        {
            return fndMangr.CreateFund(fndOpt);
        }

        [HttpPut("fund/{id}")]
        public Fund PutFund(int id, [FromBody]FundOption fndOpt)
        {
            return fndMangr.Update(fndOpt, id);
        }

        [HttpDelete("fund/delete/{id}")]
        public bool HardDeleteFund(int id)
        {
            return fndMangr.DeleteFundById(id);
        }





        //media controller

        [HttpPost("media")]
        public Media PostMedia([FromBody]MediaOption medOpt)
        {
            return medMangr.CreateMedia(medOpt);
        }

        [HttpPut("media/{id}")]
        public Media PutMedia(int id, [FromBody]MediaOption medOpt)
        {
            return medMangr.Update(medOpt, id);
        }

        [HttpDelete("media/delete/{id}")]
        public bool HardDeleteMedia(int id)
        {
            return medMangr.DeleteMediaById(id);
        }
    }
}