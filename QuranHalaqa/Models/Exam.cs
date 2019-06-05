using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuranHalaqa.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        
        public string OverAllMistakes { get; set; }
        public string OverAllSelfies { get; set; }
        public string OverAllResult { get; set; }
        public string ExamLimitMistakes { get; set; }
        public string ExamLimitSelfies { get; set; }
        public string ExamOverAllComments { get; set; }

        public int QuranJuzId { get; set; }

        //foreign keys
        public virtual Student Student { get; set; }
        public virtual QuranJuz QuranJuz { get; set; }
    }
}
