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
            var books = _db.Books.ToList();
            for (int i = 0; i < books.Count; i++)
            {
                books[i].DisplayNumber = i + 1;
            }
            return View(books);

            //Это старая запись до добавления корректного счетчика книг.
            //Можно было сделать через foreach, но была бы лишняя переменная.
            //IEnumerable<BooksModel> objList = _db.Books;
            //return View(objList);
        }

        //GET - Create
        public IActionResult Create()
        {
            string title = "";
            string author = "";
            double price;
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BooksModel obj)
        {
            _db.Books.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET - Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Books.Find(id);
            if (obj==null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST - Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BooksModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET - Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Books.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST - Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Books.Find(id);
            if (obj==null)
            {
                return NotFound();
            }
            _db.Books.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
