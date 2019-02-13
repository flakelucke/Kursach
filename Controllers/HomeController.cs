using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kursach.Models;


namespace Kursach.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context;

        public HomeController(DataContext ctx)
        { context = ctx; }

        [HttpGet("api/persons/{id}")]
        public IActionResult Index(int id)
        {
            return Ok(context.Products.First());
        }
    }
}