using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VuetAPI.Models;

namespace VuetAPI.Controllers
{ 
    [Route("api/vk_auth")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private VkAuth vk = new VkAuth("page", "https://localhost:44359/api/vk_auth/confirm", "friends");

        [HttpGet]
        public IActionResult VkAuth()
        {
            return new JsonResult(new { uri = vk.AuthenticationUri() });
        }

        [HttpGet("confirm")]
        public IActionResult Confirm(string code)
        {
            AccessToken token = vk.AccessToken(code);

            HttpContext.Session.SetString("token", token.access_token);
            HttpContext.Session.SetInt32("userId", token.user_id);

            return RedirectToAction("Token");
        }

        [HttpGet("token")]
        public JsonResult Token()
        {
            return new JsonResult(new
            {
                token = HttpContext.Session.GetString("token"),
                user_id = HttpContext.Session.GetInt32("userId")
            });
        }

    }
}
