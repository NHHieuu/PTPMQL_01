using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    { 
        public IActionResult Action1()
        {
            return View();
        } 
        public IActionResult Action2()
        {
            return View();
        }
    }
}
