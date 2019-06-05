using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace QuranHalaqa.Models
{
    public class QuranSura
    {
        [Key]
        public int QuranSuraId { get; set; }
        public string SuraName { get; set; }
        public string SuraNumber { get; set; }
        public int NumberOfAyas { get; set; }
        public int QuranJuzId { get; set; }

        //foreign keys
        public virtual QuranJuz QuranJuz { get; set; }
    }
}
