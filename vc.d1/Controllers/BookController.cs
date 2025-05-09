using Microsoft.AspNetCore.Mvc;
using vc.d1.Models;

namespace vc.d1.Controllers
{
    public class BookController : Controller
    {
        private readonly IConfiguration _configuration;
        public static List<book> _Books = book.GetBooksList();

        public BookController(IConfiguration config)
        {
            _configuration = config;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View(_Books);
        }
        [HttpGet]
        public IActionResult Book_detail(Guid id)
        {
            var book = _Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }



        [HttpGet]
        public IActionResult userdata() {
            return View();

        }

        [HttpPost]
        public IActionResult userdata(Addbook_Dto bookAdd)
        {
            if (!ModelState.IsValid)
            {
                ////keep data entered inside//////
                return View(bookAdd);
            }
            return RedirectToAction("Index");

        }
    }
}
    

