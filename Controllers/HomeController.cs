using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;
using CarPriceComparison.Services;

namespace CarPriceComparison.Controllers
{
    public class HomeController : Controller
    {
        private IMailService _mailService;

        public HomeController(IMailService mailService_)
        {
            _mailService = mailService_;
        }
        public IActionResult Index()
        {
            return View();
        }

        // public IActionResult About()
        // {
        //     ViewData["Message"] = "Your application description page.";

        //     return View();
        // }

        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactData_)
        {
            _mailService.SendMail(contactData_.EMail,"edward.milne@gmail.com", "hello there!", contactData_.Message);
            return View();
        }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
