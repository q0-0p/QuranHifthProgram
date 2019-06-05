using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuranHalaqa.Data;
using QuranHalaqa.Models;

namespace QuranHalaqa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        //create instance of database
        private HalaqaDB DB;
        //pick the value of the database for students?
        public StudentController(HalaqaDB context)
        {
            DB = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //get the students list
        public List<Student> ListStudent()
        {
            var Halaqas = DB.Student.Where(s=>s.StudentStatus != "Deleted").Include(x=>x.Halaqa).OrderBy(x=>x.StudentFirstName).ThenBy(x=>x.StudentLastName).ToList();
            return Halaqas;
        }

        //get the students list
        public List<Halaqa> ListHalaqas ()
        {
            var Halaqas = DB.Halaqa.ToList();
            return Halaqas;
        }

        public IActionResult Delete(int id)
        {
            var itemToRemove = DB.Student.SingleOrDefault(x => x.StudentId == id); //returns a single item.

            if (itemToRemove != null)
            {
                itemToRemove.StudentStatus = "Deleted" ;
                itemToRemove.HalaqaId= null;

                DB.Entry(itemToRemove).CurrentValues.SetValues(itemToRemove);

                DB.SaveChanges();
            }
            else
            {
                return NotFound(false);
            }
            return Ok(true);
        }

        [HttpPost]
        public IActionResult Save(Student student)
        {
            if (student.StudentId >= 0)
            {
                var existingStudent = DB.Student.Where(h => h.StudentId == student.StudentId).FirstOrDefault();
                if (existingStudent == null)
                {
                    return NotFound();
                }
                DB.Entry(existingStudent).CurrentValues.SetValues(student);
            }
            if (student.StudentId == -1)
            {
                //New
                student.StudentId = 0;
                DB.Student.Add(student);
            }

            DB.SaveChanges();
            return Ok();
        }
    }
}