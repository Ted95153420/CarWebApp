﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;
using CarPriceComparison.Services;
using Microsoft.Extensions.Configuration;

namespace CarPriceComparison.Controllers
{
    public class HomeController : Controller
    {
        private IVehicleRepository _vehicleRepository;
        private IMailService _mailService;
        private IConfigurationRoot _config;

        public HomeController(IMailService mailService_, IConfigurationRoot config_, IVehicleRepository vehicleRepo_)
        {
            _vehicleRepository = vehicleRepo_;
            _mailService = mailService_;
            _config = config_;
        }
        public IActionResult Index()
        {
            var vehicleData = _vehicleRepository.GetAllMakes();
            return View(vehicleData);
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
            if(ModelState.IsValid)
            {
                _mailService.SendMail(_config["MailSettings:ToAddress"],contactData_.EMail, "hello there!", contactData_.Message);
                ModelState.Clear();
                ViewBag.UserMessage = "Message succesfully sent";
            }
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
