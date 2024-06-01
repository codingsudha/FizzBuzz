using Microsoft.AspNetCore.Mvc;
using FizzBuzzApi.Model;
using Newtonsoft.Json;
using FizzBuzzApi.Services;
using Microsoft.AspNetCore.Authorization;

namespace FizzBuzzApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IFizzBuzzService _processFileService;
        public HomeController(IFizzBuzzService processFileServices)
        {
            _processFileService = processFileServices;
        }

        [HttpPost(Name = "ProcessFile")]
        public IActionResult ProcessFile(string[] inputValue)
        {
            var result = _processFileService.ProcessInput(inputValue);
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Json("Reached here!");
        }

    }
}

