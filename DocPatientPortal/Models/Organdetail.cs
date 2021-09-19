using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("organdetails")]
    public class Organdetail
    {
        [Key]
        public int org_id { get; set; }
        public string donername { get; set; }
        public string organ { get; set; }
        public string bloodgroup { get; set; }
        public long mobilenumber { get; set; }
        public string status { get; set; }

    }
}
