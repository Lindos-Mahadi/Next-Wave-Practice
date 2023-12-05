using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public JsonResult GetContactList(string searchValue, string sortOrder, int start, int length)
        {
            try
            {
                var query = _demoContext.TblContacts.AsQueryable();
                // Total records count
                int totalRecord = query.Count();
                // Filtering based on search value
                if (!string.IsNullOrEmpty(searchValue))
                {
                    query = query.Where(x => x.Name.ToLower().Contains(searchValue.ToLower()) || x.Name.ToUpper().Contains(searchValue.ToUpper()));
                }

                // Filtered records count
                int filterRecord = query.Count();
                // Sorting
                //if (!string.IsNullOrEmpty(sortOrder))
                //{
                //    // Assuming sortOrder is the name of the property to sort on
                //    query = query.OrderByProperty(sortOrder, ascending: true);
                //}
                // Paging
                var data = query.Skip(start).Take(length).ToList();

                return Json(new { data = data, recordsTotal = totalRecord, recordsFiltered = filterRecord });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        //public ActionResult GetContactList(string searchValue)
        //{
        //    int totalRecord = 0;
        //    int filterRecord = 0;
        //    var data = _demoContext.TblContacts.AsQueryable();
        //    totalRecord = data.Count();
        //    if (!string.IsNullOrEmpty(searchValue))
        //    {
        //        data = data.Where(x => x.Name.ToLower().Contains(searchValue.ToLower()));
        //    }
        //    filterRecord = data.Count();

        //    return Json(new { data = data, recordsTotal = totalRecord, recordsFiltered = filterRecord });
        //}
        //public ActionResult GetContactList(string searchValue, string sortOrder, int start, int length)
        //{
        //    // Initial query
        //    var query = _demoContext.TblContacts.AsQueryable();

        //    // Total records count
        //    int totalRecord = query.Count();

        //    // Filtering based on search value
        //    if (!string.IsNullOrEmpty(searchValue))
        //    {
        //        query = query.Where(x => x.Name.ToLower().Contains(searchValue.ToLower()));
        //    }

        //    // Filtered records count
        //    int filterRecord = query.Count();

        //    // Sorting
        //    //if (!string.IsNullOrEmpty(sortOrder))
        //    //{
        //    //    // Assuming sortOrder is the name of the property to sort on
        //    //    query = query.OrderByProperty(sortOrder, ascending: true);
        //    //}

        //    // Paging
        //    var data = query.Skip(start).Take(length).ToList();

        //    return Json(new { data = data, recordsTotal = totalRecord, recordsFiltered = filterRecord });
        //}

    }

}