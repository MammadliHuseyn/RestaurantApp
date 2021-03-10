using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ILogger<ReservationController> _logger;
        private readonly VavuDbContext _context;

        public ReservationController(VavuDbContext context, ILogger<ReservationController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //BAZAYA REZERVASIYA ELAVE ETMEK UCHUN
        [HttpPost]
        public void Book(Book book)
        {
            if (!_context.Books.Any(x => x.Email == book.Email &&
                                                            x.Name     == book.Name     &&
                                                            x.BookDate == book.BookDate &&
                                                            x.Phone    == book.Phone)   && ModelState.IsValid)
            {
                book.Date = DateTime.Now;
                _context.Books.Add(book);
                _context.SaveChanges();
            }
        }
    }
}
