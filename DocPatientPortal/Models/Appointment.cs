using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("appointment")]
    public class Appointment
    {
        [Key] 
        public int aid { get; set; }
        public int uid { get; set; }
        public int doc_id { get; set; }
        public DateTime adate { get; set; }
        public DateTime atime { get; set; }
    }
}
