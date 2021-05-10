using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoreInfoController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Info1", "Info2","How Creative" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"Your ID is:{id}";
        }
    }
}
