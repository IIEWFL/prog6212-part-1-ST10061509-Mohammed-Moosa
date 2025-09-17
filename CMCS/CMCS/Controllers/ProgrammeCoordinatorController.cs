// Code Attribution for Controller Pages:
// 1. ASP.NET Core MVC DropDownList Selected Value Not Binding On Postback — rynop — https://stackoverflow.com/questions/43803833/asp-net-core-mvc-dropdownlist-selected-value-not-binding-on-postback
//    Used as reference for binding dropdown lists in claim submission forms.
// 2. How to Bind Multiple Models in ASP.NET Core MVC Post Action — Fei Han — https://stackoverflow.com/questions/42083954/how-to-bind-multiple-models-in-asp-net-core-mvc-post-action
//    Used as reference for handling multiple models in the same POST action.
// 3. Creating Role-Based Authorization in ASP.NET Core MVC — Microsoft Docs — https://learn.microsoft.com/en-us/aspnet/core/security/authorization/roles
//    Used as reference for simulating role-based access for Lecturers, PCs, and AMs in the prototype.
// 4. Basic CRUD Operations in ASP.NET Core MVC — Microsoft Docs — https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/crud
//    Used as reference for creating actions for Create, Read, Update, and Delete in controllers.

using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class ProgrammeCoordinatorController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult ReviewClaim(int id) => View();
    }
}

