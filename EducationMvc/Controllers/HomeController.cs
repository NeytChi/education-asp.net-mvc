using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationMvc.Models;

namespace EducationMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookContext _context = new BookContext();
 
        public ActionResult Index()
        {
            var books = _context.Books;
            ViewBag.Books = books;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            _context.Purchases.Add(purchase);
            _context.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }
    }
}