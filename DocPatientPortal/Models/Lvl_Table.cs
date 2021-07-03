using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("lvl_table")]
    public class Lvl_Table
    {
        [Key]
        public int id { get; set; }
        public int t_id { get; set; }
        public String level{ get; set; }

        public Lvl_Table(int t_id, String level)
        {
            this.t_id = t_id;
            this.level = level;
        }
    }
}
