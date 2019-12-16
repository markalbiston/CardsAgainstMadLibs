using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CardsAgainstMadLibs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace CardsAgainstMadLibs.Controllers
{
    public class GameController : Controller
    {
        private CardsAgainstMadLibsContext dbContext;
        public GameController(CardsAgainstMadLibsContext context)
        {
            dbContext = context;
        }

        [HttpGet("/welcome")]
        public IActionResult Welcome()
        {
            return View();
        }

        [HttpGet("/card")]
        public IActionResult CardInput()
        {
            return View();
        }

    }
}