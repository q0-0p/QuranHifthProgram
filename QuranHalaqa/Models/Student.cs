using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace QuranHalaqa.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentNumber { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string ParentName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string StudentStatus { get; set; }
        public string Reason { get; set; }

        //foreign keys
        public int? HalaqaId { get; set; }
        //foreign keys
        public virtual Halaqa Halaqa { get; set; }
        public virtual List<StudentWork>  StudentWork {get; set; }
        //Add-Migration -Context HalaqaDB "v4"
        //Update-Database -Context HalaqaDB
}
}
