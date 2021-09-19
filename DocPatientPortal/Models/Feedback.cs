using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("feedbacks")]
    public class Feedback
    {
        [Key]
        public int fid { get; set; }
        public string fullname { get; set; }
        public string role { get; set; }
        public string message { get; set; }
    }
}
