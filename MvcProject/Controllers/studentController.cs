

using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers{

public class studentController : Controller{
    public IActionResult Index()
    {
         //Khai bao 1 doi tuong Student va gan gia tri
            student std = new student();
            std.Id = "2121050189";
            std.Name = "Nguyễn Hồng Hiếu";
            return View(std);
    }
    [HttpGet] 
    public IActionResult Guinhandulieu(){
        return View();
    }
    [HttpPost]
    public IActionResult Guinhandulieu(student std){
        ViewBag.Message = "ID:" + std.Id +  "Name:"+ std.Name;
        return View(std);
    }

}
}

