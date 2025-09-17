using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class ProgrammeCoordinatorController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult ReviewClaim(int id) => View();
    }
}

