using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace QuranHalaqa.Models
{
    public class StudentWork
    {
        [Key]
        public int StudentWorkId { get; set; }
        public int HalaqaSessionId {get;set;}
        public int StudentId { get; set; }
        public string WorkDueDate { get; set; }


        public string AssignedWorkStatus { get; set; } //Passed, Failed, NotCompleted
        public string AssignedWork { get; set; }
        public string NewWork { get; set; }
        public string RevisionStatus { get; set; } //Passed, Failed, NotCompleted
        public string Revision { get; set; }
        public string NewRevision { get; set; }
        public int RevisionSelfies { get; set; }
        public int RevisionMistakes { get; set; }
        public int AssignedWorkSelfies { get; set; }
        public int AssignedWorkMistakes { get; set; }
        public string Comment { get; set; }

        public bool IsPresent { get; set; }
        //foreign keys
        public virtual Student Student { get; set; }
        public virtual HalaqaSession HalaqaSession { get; set; }

    }
}
