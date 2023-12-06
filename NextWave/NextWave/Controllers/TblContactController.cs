using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NextWave.Models;
using System.Linq.Dynamic.Core;
using System.Net.NetworkInformation;

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
        public string GetContactList()
        {
            try
            {
                var query = _demoContext.TblContacts.ToList();
                var contactList = JsonConvert.SerializeObject(new { data = query});
                return contactList;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }

}