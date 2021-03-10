using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;
using VavuBakuMVCcore.ViewModels;

namespace VavuBakuMVCcore.ViewComponents
{
    public class BookViewComponent:ViewComponent
    {
        private readonly VavuDbContext _context;
        private string phone;

        public BookViewComponent(VavuDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            phone = _context.Settings.FirstOrDefault().Phone;
            return View("Default",phone);
        }
    }
}
