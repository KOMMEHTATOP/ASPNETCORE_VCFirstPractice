using Microsoft.AspNetCore.Mvc;
using VCFirstPractice.Data;
using VCFirstPractice.Models;

namespace VCFirstPractice.Controllers
{
    public class MyPageController : Controller
    {

        private readonly ApplicationDbContext _db;

        public MyPageController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<BooksModel> objList = _db.Books;
            return View(objList);
        }        
        
        //GET
        public IActionResult AddNewBook()
        {
            string title = "";
            string author = "";
            double price;
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewBook(BooksModel obj)
        {
            _db.Books.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
