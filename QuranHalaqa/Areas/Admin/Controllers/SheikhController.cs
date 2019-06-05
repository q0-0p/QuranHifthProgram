using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuranHalaqa.Data;
using QuranHalaqa.Models;

namespace QuranHalaqa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SheikhController : Controller
    {
        private HalaqaDB DB;
        public SheikhController(HalaqaDB context)
        {
            DB = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public List<Sheikh> ListSheikh()
        {
            var Sheikhs = DB.Sheikh.OrderBy(s => s.SheikhFirstName).ToList();
            return Sheikhs;
        }

        public IActionResult Delete(int id)
        {
            var itemToRemove = DB.Sheikh.SingleOrDefault(x => x.SheikhId == id); //returns a single item.

            if (itemToRemove != null)
            {
               var halaqas = DB.Halaqa.Where(s => s.SheikhId == id);
               if(halaqas.Count() > 0)
                {
                    return Ok(false);
                }
                DB.Sheikh.Remove(itemToRemove);
                DB.SaveChanges();
            }
            else
            {
                return NotFound(false);
            }
            return Ok(true);
        }

        [HttpPost]
        public IActionResult Save([FromBody] Sheikh sheikh)
        {
            if (sheikh.SheikhId >= 0)
            {
                var existingSheikh = DB.Sheikh.Where(h => h.SheikhId == sheikh.SheikhId).FirstOrDefault();
                if (existingSheikh == null)
                {
                    return NotFound();
                }
                DB.Entry(existingSheikh).CurrentValues.SetValues(sheikh);
            }

            else if (sheikh.SheikhId == -1)
            {
                //New
                sheikh.SheikhId = 0;
                DB.Sheikh.Add(sheikh);
            }
           

            DB.SaveChanges();
            return Ok();
        }
    }
}