using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Controllers
{
    public class ContactController : Controller
    {
        private readonly VavuDbContext _context;
        private Setting _setting;
        public ContactController(VavuDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            _setting = _context.Settings.FirstOrDefault();
            return View(_setting);
        }

        //BAZAYA KLIENT MESAJ ELAVE ETMESI UCHUN
        [HttpPost]
        public void SendMessage(ContactMessage msg)
        {

            if(!_context.ContactMessages.Any(x=> x.Email == msg.Email && 
                                                            x.Subject == msg.Subject &&
                                                            x.Message == msg.Message &&
                                                            x.Phone   == msg.Phone)  && ModelState.IsValid)
            {
                msg.Date = DateTime.Now;
                _context.ContactMessages.Add(msg);
                _context.SaveChanges();
            }
            
        }
    }
}
