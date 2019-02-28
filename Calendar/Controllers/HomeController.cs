using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendar.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calendar.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            var events = _context.Events.ToList();

            return Json(events);
        }

        [HttpPost]
        public JsonResult SaveEvent(Event e)
        {
            var status = false;

            if (e.EventID > 0)
            {
                //Update the event
                var v = _context.Events.Where(a => a.EventID == e.EventID).FirstOrDefault();
                if (v != null)
                {
                    v.Subject = e.Subject;
                    v.Start = e.Start;
                    v.End = e.End;
                    v.Description = e.Description;
                    v.IsFullDay = e.IsFullDay;
                    v.ThemeColor = e.ThemeColor;
                }
            }
            else
            {
                _context.Events.Add(e);
            }
            _context.SaveChanges();
            status = true;

            return Json(status);
        }

        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;

            var v = _context.Events.Where(a => a.EventID == eventID).FirstOrDefault();
            if (v != null)
            {
                _context.Events.Remove(v);
                _context.SaveChanges();
                status = true;
            }

            return Json(status);
        }
    }
}
