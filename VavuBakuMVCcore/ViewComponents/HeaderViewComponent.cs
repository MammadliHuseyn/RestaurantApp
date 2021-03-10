using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;
using VavuBakuMVCcore.ViewModels;

namespace VavuBakuMVCcore.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly VavuDbContext _context;
        private LayoutViewModel model;

        public HeaderViewComponent(VavuDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<SocialMedia> socialMedias = _context.SocialMedias.ToList();
            Setting setting = _context.Settings.FirstOrDefault();
            List<Food> foods = _context.Foods.ToList();

            model = new LayoutViewModel()
            {
                SocialMedias = socialMedias,
                Setting = setting,
                Foods = foods
            };

            return View(model);
        }
    }
}
