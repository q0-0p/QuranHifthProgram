using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace QuranHalaqa.Models
{
    public class QuranJuz
    {
        [Key]
        public int QuranJuzId { get; set; }
        public string JuzName { get; set; }
        public string JuzNumber { get; set; }
     
    }
}
