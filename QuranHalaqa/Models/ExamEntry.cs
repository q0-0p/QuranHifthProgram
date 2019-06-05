using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuranHalaqa.Models
{
    public class ExamEntry
    {
        [Key]
        public int ExamEntryId { get; set; }
        public int ExamId { get; set; }
        //public int QuranSuraId { get; set; }
        public string SuraMistakes { get; set; }
        public string SuraSelfies { get; set; }
        public string SuraResult { get; set; }
        public string SuraComment { get; set; }

        //foreign keys
        public virtual Exam Exam { get; set; }
        //[ForeignKey("QuranSuraId")]
        //public virtual QuranSura QuranSura { get; set; }
    }
}
