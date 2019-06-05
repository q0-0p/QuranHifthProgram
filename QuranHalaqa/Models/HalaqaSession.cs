using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuranHalaqa.Models
{
    public class HalaqaSession
    {
        [Key]
        public int HalaqaSessionId { get; set; }
        public int HalaqaId { get; set; }
        public DateTime HalaqaSessionDate { get; set; }
        public bool IsCanceled { get; set; }
        public string ReasonCanceled { get; set; }

        public virtual Halaqa Halaqa { get; set; }
        public virtual List<StudentWork> StudentWork { get; set; }
    }
}
