using Microsoft.AspNetCore.Mvc;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Users.ToList();
            return View(data);
        }

        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            return View(_context.Users.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            return View(_context.Users.Find(id));
        }
        public IActionResult Delete(int? id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
