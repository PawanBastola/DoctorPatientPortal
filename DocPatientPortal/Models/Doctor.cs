using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("doctor")]
    public class Doctor
    {
        [Key]
        public int did { get; set; }
        public string dname { get; set; }
        public string dspeciality { get; set; }
        public int droomno { get; set; }
        public string daddress { get; set; }
        public string dgender { get; set; }
        public long dnumber { get; set; }
        public string dmail { get; set; }
        public string dacademicqual { get; set; }
    }
}
