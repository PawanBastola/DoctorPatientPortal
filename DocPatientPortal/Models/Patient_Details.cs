using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("patient_details")]
    public class Patient_Details
    {
        [Key]
        public int p_id { get; set; }
        public String p_fullname { get; set; }
        public DateTime p_dob { get; set; }
        public String p_contact { get; set; }
        public String p_email { get; set; }
        public String p_photo { get; set; }
        public String p_state { get; set; }
        public String p_city { get; set; }
        public String p_gender { get; set; }
        public String p_fulladdress { get; set; }
        public String p_blood { get; set; }
        [ForeignKey("userlogin")]
        public String p_username { get; set; }

    }
}
