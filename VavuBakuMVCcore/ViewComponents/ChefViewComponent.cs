using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.ViewComponents
{
    public class ChefViewComponent:ViewComponent
    {
        private readonly VavuDbContext _context;
        private List<Chef> _chefs = new List<Chef>();
        public ChefViewComponent(VavuDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            _chefs = _context.Chefs.ToList();
            return View(_chefs);
        }
    }
}
