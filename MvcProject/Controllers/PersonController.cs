using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
