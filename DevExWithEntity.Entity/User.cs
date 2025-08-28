using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExWithEntity.Entity
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<Tab> Tabs { get; set; }
        public virtual ICollection<Calender> Calenders { get; set; }
    }
}
