using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("speciality")]
    public class Speciality
    {
        public int id { get; set; }
        public string spec { get; set; }
    }
}
