using System;
using System.Linq;

namespace DevExWithEntity.Entity
{
    public class Log
    {
        public int ID { get; set; }
        public int SessionID { get; set; }
        public virtual Session Session { get; set; }
        public string TableName { get; set; }
        public string FormNo { get; set; }
        public int RecordID { get; set; }
        public LogActionType ActionType { get; set; }
        public DateTime ActionDate { get; set; }
        public string Details { get; set; }

        public enum LogActionType
        {
            Insert,
            Update,
            Delete,
            Login,
            Logout,
            FormOpen,
            FormClose
        }
    }
}
