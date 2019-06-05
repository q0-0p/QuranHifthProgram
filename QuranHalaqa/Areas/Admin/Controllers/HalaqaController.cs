using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuranHalaqa.Data;
using QuranHalaqa.Models;

namespace QuranHalaqa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HalaqaController : Controller
    {
        private HalaqaDB DB;
        public HalaqaController(HalaqaDB context )
        {
            DB = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public List<Halaqa> ListHalaqas()
        {
            var Halaqas = DB.Halaqa.OrderBy(h=>h.HalaqaName).Include(H => H.Sheikh).Include(H => H.Student).ToList();
            return Halaqas;
        }

        public List<HalaqaSession> ListHalaqaHistory(int id)
        {
            var HalaqasSessions = DB.HalaqaSession.Where(hs=>hs.HalaqaId == id).OrderByDescending(hs=>hs.HalaqaSessionDate).ToList();
            return HalaqasSessions;
        }

        public HalaqaSession ListSessionDetails(int id)
        {
            var HalaqasSessions = DB.HalaqaSession.Include(s => s.StudentWork).Include(s => s.StudentWork).ThenInclude(x=>x.Student).Where(HS => HS.HalaqaSessionId == id).FirstOrDefault(); ;
            return HalaqasSessions;// HalaqasSessions;
        }

        public List<Sheikh> ListSheikh()
        {
            var Sheikhs = DB.Sheikh.OrderBy(s=>s.SheikhFirstName).ToList();
            return Sheikhs;
        }

        public List<Student> ListStudents()
        {
            var Students = DB.Student.Where(s=>s.StudentStatus == "Active" || s.StudentStatus == "WaitingList").ToList();
            return Students;
        }

        public IActionResult Delete(int id)
        {
            var itemToRemove = DB.Halaqa.SingleOrDefault(x => x.HalaqaId == id); //returns a single item.

            if (itemToRemove != null)
            {
                var students = DB.Student.Where(s => s.HalaqaId == id);
                foreach(var student in students)
                {
                    student.HalaqaId = null;
                }
                DB.Halaqa.Remove(itemToRemove);
                DB.SaveChanges();
            }
            else
            {
                return NotFound(false);
            }
            return Ok(true);
        }

        [HttpPost]
        public IActionResult Save(Halaqa halaqa)
        {

            //ADD Checks Here.


            if(halaqa.HalaqaId>=0)
            {
                var existingHalaqa = DB.Halaqa.Where(h => h.HalaqaId == halaqa.HalaqaId).FirstOrDefault();
                if(existingHalaqa == null) {
                    return NotFound();
                }
                DB.Entry(existingHalaqa).CurrentValues.SetValues(halaqa);
            }

            if(halaqa.HalaqaId == -1)
            {
                //New
                halaqa.HalaqaId = 0;
                DB.Halaqa.Add(halaqa);
            }

            DB.SaveChanges();
            return Ok();
        }
    }
}