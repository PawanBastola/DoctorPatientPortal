using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("unavailability")]
    public class Unavailability
    {
        [key]
        public int id { get; set; }
        public int did { get; set; }
        public String absent_date { get; set; }
    }
}
