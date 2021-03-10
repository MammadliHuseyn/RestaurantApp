using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VavuBakuMVCcore.Models;
using VavuBakuMVCcore.ViewModels;

namespace VavuBakuMVCcore.Controllers
{
    public class MenuController : Controller
    {
        private readonly ILogger<MenuController> _logger;
        private readonly VavuDbContext _context;
        MenuViewModel model = new MenuViewModel();

        public MenuController(ILogger<MenuController> logger, VavuDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            model.FoodCategories = _context.FoodCategories
                                        .OrderBy(x => x.Order)
                                                        .Include("Foods").ToList();
            model.Foods = _context.Foods.ToList();

            return View(model);
        }
    }
}
