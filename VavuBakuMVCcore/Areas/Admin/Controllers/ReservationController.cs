using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {
        private readonly VavuDbContext _context;
        private List<Book> _books;

        public ReservationController(VavuDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            _books = _context.Books.ToList();
            return View(_books);
        }
    }
}
