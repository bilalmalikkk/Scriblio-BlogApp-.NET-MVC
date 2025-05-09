using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;
using BlogApp.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var posts = _context.BlogPosts.OrderByDescending(b => b.CreatedAt).ToList();
            return View(posts);
        }

        public IActionResult Details(int id)
        {
            var post = _context.BlogPosts.Find(id);
            if (post == null) return NotFound();
            return View(post);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogPost post)
        {
            if (ModelState.IsValid)
            {
                _context.Add(post);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }
        public IActionResult Edit(int id)
        {
            var post = _context.BlogPosts.Find(id);
            if (post == null) return NotFound();
            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogPost post)
        {
            if (ModelState.IsValid)
            {
                _context.Update(post);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }
        public IActionResult Delete(int id)
        {
            var post = _context.BlogPosts.Find(id);
            if (post == null) return NotFound();
            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var post = _context.BlogPosts.Find(id);
            if (post == null)
            {
                return NotFound();
            }
            _context.BlogPosts.Remove(post);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
