using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookApi.Controllers
{
    [RoutePrefix("api/v1/Login")]
    public class LoginController : ApiController
    {
        [HttpPost, HttpGet]
        [Route("Login")]
        public IHttpActionResult Login(String username, String password)
        {
            return Json(new
            {
                status = true,
                msg = "Account is exist"
            });
        }
    }
}
