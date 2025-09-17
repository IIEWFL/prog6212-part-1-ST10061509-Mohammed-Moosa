using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class AcademicManagerController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult ApproveClaim(int id) => View();
    }
}

