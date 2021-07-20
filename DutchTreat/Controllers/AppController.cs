﻿using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller 
    {
        private readonly IMailService _mailService;
        private readonly DutchContext _context;

        public AppController(IMailService mailService, DutchContext context)
        {
            _mailService = mailService;
            _context = context;
        }
        public IActionResult Index()
        {
            var results = _context.Products.ToList();
            return View(); 
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                _mailService.SendMessage("seantrevoredwards@gmail.com", model.Subject, $"From {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail sent";
                ModelState.Clear();
            }
            else
            {

            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        public IActionResult Shop()
        {
            var results = _context.Products.OrderBy(p => p.Category).ToList();

            return View(results);
        }

    }
}
