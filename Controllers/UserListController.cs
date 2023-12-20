﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokenAPI.Controllers
{
    [Route("api/userlist")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    [Authorize]
    public class UserListController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var userlist = await Task.FromResult(new string[] { "Virat", "Messi", "Ozil", "Lara", "MS Dhoni" });
            return Ok(userlist);
        }
    }
}

