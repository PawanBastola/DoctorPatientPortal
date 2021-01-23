using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models.BLL
{
    class UserLoginBll
    {

        public string username { get; set; }
        public string password { get; set; }
        string role { get; set; }
        public bool _isAdmin {
            get
            {
                return false;
            }
            set
            {
                if (role =="admin")
                {
                    value = true;
                }
            }
        }
    }
}
