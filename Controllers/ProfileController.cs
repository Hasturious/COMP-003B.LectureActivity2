using System.Diagnostics;
using COMP_003B.LectureActivity2.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP_003B.LectureActivity2.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]

        public IActionResult About()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
