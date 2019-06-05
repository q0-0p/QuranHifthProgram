using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuranHalaqa.Models
{
    public class Contacts
    {
        [Key]
        public int ContactsId { get; set; }
        public int StudentId { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string RelationshipToStudents { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
        
        //foreign keys
        public virtual Student Student { get; set; }
    }
}
