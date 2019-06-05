using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuranHalaqa.Models
{
    public class Sheikh
    {
        [Key]
        public int SheikhId { get; set; }
        public string SheikhFirstName { get; set; }
        public string SheikhLastName { get; set; }
        public string SheikhCellNumber { get; set; }
        public string SheikhHomeAddress { get; set; }
        public string SheikhEmail { get; set; }

    }
}
