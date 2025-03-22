﻿using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Controllers
{
    public class DefaultController : Controller
    {

        private readonly CafeContext _context;

        public DefaultController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Features.ToList();
            ViewBag.Subtitle = _context.Features.Select(x => x.SubTitle).FirstOrDefault();
            ViewBag.Title = _context.Features.Select(x => x.Title).FirstOrDefault();
            return View(value);
        }
    }
}
