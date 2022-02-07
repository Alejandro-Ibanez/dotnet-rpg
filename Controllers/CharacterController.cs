using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("character")]
    public class CharacterController : ControllerBase
    {
        private static Character knigth = new Character();
        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(knigth);
        }

    }
}