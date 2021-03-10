using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Controllers
{
    public class AboutController : Controller
    {
        private readonly VavuDbContext _context;
        private About _about;

        public AboutController(VavuDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            _about = _context.Abouts.FirstOrDefault();
            return View(_about);
        }
    }
}
