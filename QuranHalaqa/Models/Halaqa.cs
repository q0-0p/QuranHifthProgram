using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuranHalaqa.Models
{
    public class Halaqa
    {
        [Key]
        public int HalaqaId { get; set; }
        public int SheikhId { get; set; }
        public string HalaqaName { get; set; }
        public DateTime HalaqaStartDate { get; set; }
        public DateTime? HalaqaEndDate { get; set; }

        public string HalaqaStartTime { get; set; }
        public string HalaqaEndTime { get; set; }

        public bool DaySaturday { get; set; }
        public bool DaySunday { get; set; }
        public bool DayMonday { get; set; }
        public bool DayTuesday { get; set; }
        public bool DayWednesday { get; set; }
        public bool DayThursday { get; set; }
        public bool DayFriday { get; set; }


        public DateTime CreationDate { get; set; }

        //foreign keys
        public virtual Sheikh Sheikh { get; set; }
        public virtual List<Student> Student { get; set; } // Added to connect halaqa to students. (And cont too)
    }
}
