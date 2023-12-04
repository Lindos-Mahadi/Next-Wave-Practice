using Microsoft.AspNetCore.Mvc;
using NextWave.Models;

namespace NextWave.Controllers
{
    public class TblContactController : Controller
    {
        private readonly NextWaveDbContext _demoContext;

        public TblContactController(NextWaveDbContext demoContext)
        {
            _demoContext = demoContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetContactList()
        { 
            var contactList = _demoContext.TblContacts.ToList().Take(20);
            return Json(contactList);
        }
    }
}
