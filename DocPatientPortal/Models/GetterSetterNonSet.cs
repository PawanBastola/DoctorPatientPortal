using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{

    //practice for ranjan
    public class GetterSetterNonSet
    {


        public int UserId { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        string role = "user";
        public string UserRole
        {
            get{
                return role;
            }
        }

        
    }
}
