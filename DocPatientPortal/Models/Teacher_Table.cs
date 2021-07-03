using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("teacher_table")]
    public class Teacher_Table
    {
        public int id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
    }
}
