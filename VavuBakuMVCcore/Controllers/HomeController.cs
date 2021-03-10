using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VavuBakuMVCcore.Models;
using VavuBakuMVCcore.ViewModels;

namespace VavuBakuMVCcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VavuDbContext _context;
        HomeViewModel model = new HomeViewModel();

        public HomeController(ILogger<HomeController> logger, VavuDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            model.Services = _context.Services.ToList();
            model.Sliders = _context.Sliders.ToList();
            model.FoodCategories = _context.FoodCategories
                                                    .OrderBy(x => x.Order)
                                                                    .Include("Foods").ToList();
            model.Foods = _context.Foods.ToList();
            model.Campaigns = _context.Campaigns.ToList();
            model.Activities = _context.Activities.ToList();

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
