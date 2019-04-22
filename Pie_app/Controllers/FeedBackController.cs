using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pie_app.Model;

namespace Pie_app.Controllers
{
    [Authorize]
    public class FeedBackController : Controller
    {
        private readonly IFeedBackRespo _feedBackRespo;
       
        public FeedBackController(IFeedBackRespo feedBackRespo)
        {
            _feedBackRespo = feedBackRespo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FeedBack feedBack)
        {
            if (ModelState.IsValid)
            {
                _feedBackRespo.AddFeedback(feedBack);
                return RedirectToAction("FeedbackComplete");
            }
            return View(feedBack);
            
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}