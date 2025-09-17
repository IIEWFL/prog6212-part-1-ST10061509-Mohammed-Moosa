using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult SubmitClaim() => View();
        public IActionResult MyClaims() => View();
        public IActionResult UploadDocument() => View();
    }
}

