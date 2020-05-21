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
    [Route("[controller]/create")]
    public class FunderController : ControllerBase
    {


        private readonly ILogger<FunderController> _logger;
        private readonly IUserManager usrMangr;
        // private readonly IProductManager prodMangr;
        //private readonly IBasketManager baskMangr;


        public FunderController(ILogger<FunderController> logger,
            IUserManager _usrMangr //IProductManager _prodMangr,
                                   //IBasketManager _baskMangr
            )
        {
            _logger = logger;
            usrMangr = _usrMangr;
            // prodMangr = _prodMangr;
            // baskMangr = _baskMangr;
        }

        [HttpGet("")]
        public string Get()
        {  
            return "Join us!";
        }

        //[HttpGet("all")]
        //public List<User> GetAllCustomers()
        //{

        //    return usrMangr.GetAllCustomers();
        //}



        //[HttpGet("{id}")]
        //public User GetUser(int id)
        //{

           // return usrMangr.FindUserById(id);
       // }

        //           [FromForm]    [FromBody]   [FromRoute]
        /*
         The FromForm attribute is for incoming data from a submitted form sent 
        by the content type application/x-www-url-formencoded w
            hile the FromBody will parse the model the default way, 
            which in most cases are sent by the content type application/json,
 */


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

        [HttpDelete("hard/{id}")]
        public bool HardDeleteUser(int id)
        {
            return usrMangr.DeleteUserById(id);
        }

        

        //project soon 
        //[HttpPost("{userId}/basket")]
        //public Basket CreateBasket(int customerId)
        //{
        //    BasketOption bskOption = new BasketOption
        //    {
        //        CustomerId = customerId
        //    };

        //    return baskMangr.CreateBasket(bskOption);
        //}

        //[HttpPost("basket/{basketId}/product/{productId}")]
        //public BasketProduct AddToBasket(int basketId, int productId)
        //{
        //    BasketProductOption bskProd = new BasketProductOption
        //    {
        //        BasketId = basketId,
        //        ProductId = productId
        //    };

        //    return baskMangr.AddProduct(bskProd);
        //}

    }
}