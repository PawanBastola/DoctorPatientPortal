using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models.ViewModel
{
    public class ViewModelAppointment
    {
        public int aid { get; set; }
        public int uid { get; set; }
        public int doc_id { get; set; }
        public DateTime adate { get; set; }
        public String patient_name { get; set; }
    }
}
