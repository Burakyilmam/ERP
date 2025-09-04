using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Entity
{
    public class Email
    {
        [Key]
        public int ID { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 0 - Personal , 1 - Work
        /// </summary>
        public byte EmailType { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }

        public string UpdatedBy { get; set; }

        public bool IsPrimaryEmail { get; set; }
        public bool IsActive { get; set; }
    }
}
