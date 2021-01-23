using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        public int pid { get; set; }
        public string pname { get; set; }
        public string paddress { get; set; }
        public string pblood { get; set; }
    }
}
