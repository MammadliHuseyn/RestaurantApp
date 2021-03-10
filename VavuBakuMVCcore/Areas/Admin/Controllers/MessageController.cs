using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly VavuDbContext _context;
        List<ContactMessage> messages = new List<ContactMessage>();

        public MessageController(VavuDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            messages = _context.ContactMessages.ToList();
            return View(messages);
        }
    }
}
