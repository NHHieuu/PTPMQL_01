

using Microsoft.AspNetCore.Mvc;

namespace MvcProject.Controllers;

public class studentController : Controller{
    public IActionResult Index()
    {
        return View();
    }


}

