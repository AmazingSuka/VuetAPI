using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using VkNet;
using Microsoft.AspNetCore.Mvc;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace VuetAPI.Models
{
    [Route("api")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        [HttpGet("friends")]
        public IActionResult Friends()
        {
            return null;
        }

        [HttpGet("send")]
        public IActionResult Send()
        {
            VkApi vk = new VkApi();
            vk.Authorize(new ApiAuthParams { AccessToken = "f6870fb6c1d68a5644ec863b113a1e76453c8ffe1e04d186143dca5eeca8573e6787c010b30ae13e040de" });
            vk.Messages.Send(new MessagesSendParams { RandomId = 53249, Message = "Test", UserId = HttpContext.Session.GetInt32("userId") });
            return new JsonResult(HttpContext.Session.GetInt32("userId"));
        }
    }
}