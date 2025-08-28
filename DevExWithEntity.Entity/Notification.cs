using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Entity
{
    public class Notification
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public string RelatedForm { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte NotificationType { get; set; }
        public object RelatedObject { get; set; }
        public byte Priority { get; set; }
    }
}
