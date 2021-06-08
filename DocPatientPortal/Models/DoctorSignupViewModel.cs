using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    public class DoctorSignupViewModel
    {

        public String d_full_name { get; set; }
        public DateTime d_dob { get; set; }
        public String d_contact { get; set; }
        public String d_email { get; set; }
        public String d_certificate { get; set; }
        public String d_state { get; set; }
        public String d_city { get; set; }
        public String d_full_address { get; set; }
        public String d_gender { get; set; }
        public String d_blood_group { get; set; }
        public String d_speciality { get; set; }
        public String username { get; set; }

        [DataType(DataType.Password)]
        public String password { get; set; }


    }
}
