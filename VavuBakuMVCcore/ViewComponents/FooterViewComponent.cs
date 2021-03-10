using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VavuBakuMVCcore.Models;
using VavuBakuMVCcore.ViewModels;

namespace VavuBakuMVCcore.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly VavuDbContext _context;
        private LayoutViewModel model;

        public FooterViewComponent(VavuDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<SocialMedia> socialMedias = _context.SocialMedias.ToList();
            Setting setting = _context.Settings.FirstOrDefault();

            model = new LayoutViewModel()
            {
                SocialMedias = socialMedias,
                Setting = setting
            };

            return View(model);
        }
    }
}
