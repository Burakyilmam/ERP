using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Entity
{
    public class Session
    {
        public int ID { get; set; }
        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public string MachineName { get; set; }
        public string DeviceInfo { get; set; }
        public string WindowsUsername { get; set; }
        public string IPAddress { get; set; }
        public DateTime LoginDate { get; set; }
        public TimeSpan? SessionDuration { get; set; }
        public DateTime? LogoutDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string ActiveForm { get; set; }
        public int FailedLoginAttempts { get; set; }
        public string GeoLocation { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
