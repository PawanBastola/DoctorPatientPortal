using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("prescription")]
    public class Prescription
    {
        public int id { get; set; }
        public int p_id { get; set; }
        public String information { get; set; }
        public String medication { get; set; }

    }
}
