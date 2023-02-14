using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NewProtoNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // api/Category
    public class CategoryController : Controller
    {

        [HttpGet("{id}")]
        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        // GET: CategoryController/Create
        public ActionResult GatCategories()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
