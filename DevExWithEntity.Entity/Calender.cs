using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExWithEntity.Entity
{
    public class Calender
    {
        [Key]

        public int ID { get; set; }
        public DateTime CurrentDate { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
