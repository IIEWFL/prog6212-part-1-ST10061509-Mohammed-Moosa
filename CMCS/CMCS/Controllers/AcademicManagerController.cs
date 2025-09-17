// Code Attribution for Controllers:
// 1. ASP.NET Core MVC DropDownList Selected Value Not Binding On Postback — rynop
//    https://stackoverflow.com/questions/43803833/asp-net-core-mvc-dropdownlist-selected-value-not-binding-on-postback
// 2. How to Bind Multiple Models in ASP.NET Core MVC Post Action — Fei Han
//    https://stackoverflow.com/questions/42083954/how-to-bind-multiple-models-in-asp-net-core-mvc-post-action
// 3. Uploading files in ASP.NET Core MVC — Rick Strahl
//    https://weblog.west-wind.com/posts/2019/Jan/21/Handling-File-Uploads-in-ASPNET-Core
// 4. Displaying validation messages in Razor Views — Microsoft Docs
//    https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation
// 5. Redirecting with TempData messages — Damir Arh
//    https://stackoverflow.com/questions/40393760/asp-net-core-mvc-redirecttoaction-with-message

using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class AcademicManagerController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult ApproveClaim(int id) => View();
    }
}

