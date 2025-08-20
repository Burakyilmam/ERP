using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Entity
{
    public class Tab
    {
        public int ID { get; set; }
        public string TabName { get; set; }
        public string FormNo { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime FirstOpenDate { get; set; }
        public int OpenCount { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
