using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiderBoard.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult KYCL1()
        {
            return View();
        }
        public IActionResult KYCL2()
        {
            return View();
        }
        public IActionResult SearchAgentKYC()
        {
            return View();
        }

        public IActionResult SetupAgent()
        {
            return View();
        }
        public IActionResult ManageAgent()
        {
            return View();
        }
        public IActionResult RegisterAgent()
        {
            return View();
        }

        public IActionResult POSBulk()
        {
            return View();
        }
        public IActionResult TIDBulk()
        {
            return View();
        }
        public IActionResult POSSingle()
        {
            return View();
        }
        public IActionResult TIDSingle()
        {
            return View();
        }

        

        public IActionResult ViewAllPOS()
        {
            return View();
        }
        public IActionResult ViewAllTID()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            return View();
        }

        public IActionResult ErrorDocumentation()
        {
            return View();
        }
        public IActionResult BroadCast()
        {
            return View();
        }
        public IActionResult Overview()
        {
            return View();
        }
        public IActionResult SearchAgentSupport()
        {
            return View();
        }


    }
}
