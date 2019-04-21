using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pie_app.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pie_app.Controllers
{
    public class HomeController : Controller
    {
        public readonly IPieRespo _pieRespo;

        public HomeController(IPieRespo pieRespo)
        {
            _pieRespo = pieRespo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Pie overview";

            var pies = _pieRespo.GetAllPies().OrderBy(p => p.Name);
            return View(pies);
        }
    }
}
