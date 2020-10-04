using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using CSGOBet.Extensions;

namespace CSGOBet.Controllers
{
    [ApiController]
    public class AuthenticationController : Controller
    {
        [HttpGet("/login")]
        public IActionResult Login()
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = "/" }, "Steam");
        }
        [HttpGet("api/auth/isAuth")]
        public bool IsAuthenticated()
        {
            return HttpContext.User.Identity.IsAuthenticated;
        }
    }
}
