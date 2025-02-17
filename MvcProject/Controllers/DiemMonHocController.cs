using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class DiemMonHocController : Controller
    {
        [HttpGet]
        public IActionResult TinhDiem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TinhDiem(TinhDiem diem)
        {
                diem.DiemTong = (diem.DiemA * 0.6f) + (diem.DiemB * 0.3f) + (diem.DiemC * 0.1f);

                ViewBag.DiemTong = diem.DiemTong;

                return View(diem);
        }
    }
}
