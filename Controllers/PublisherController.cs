using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class PublisherController : Controller
    {
        ApplicationDbContext DbContext;
        public PublisherController(ApplicationDbContext dbContext) 
        { 
            this.DbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Publisher> publishers = DbContext.Publishers.ToList();
            return View(publishers);
        }

        public IActionResult Details(int id) {
            var publisher = DbContext.Publishers.Find(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }
    }
}
