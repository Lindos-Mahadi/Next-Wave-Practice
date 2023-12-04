using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NextWave.Models;

namespace NextWave.Controllers
{
    public class DemoController : Controller
    {
        private readonly NextWaveDbContext _demoContext;
        public DemoController(NextWaveDbContext demoContext)
        {
            _demoContext = demoContext;
        }
        // GET: DemoController
        public ActionResult Index()
        {
            var addressList = _demoContext.TblCompanies.ToList();
            return View(addressList);
        }
        [HttpGet]
        public IActionResult GetCompanyData()
        {
            // Assuming you have a service or repository to fetch the data
            var companies = _demoContext.TblCompanies.ToList().Take(25);

            // You can return the data as JSON
            return Json(new { data = companies });
        }

        // GET: DemoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DemoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DemoController/Create
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

        // GET: DemoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DemoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: DemoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DemoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
