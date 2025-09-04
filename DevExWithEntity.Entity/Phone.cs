using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Entity
{
    public class Phone
    {
        [Key]
        public int ID { get; set; }

        public string PhoneNumber { get; set; }

        public string CountryCode { get; set; }

        /// <summary>
        /// 0 - Home , 1 - Work , 2 - Personal
        /// </summary>        
        public byte PhoneType { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }

        public string UpdatedBy { get; set; }

        public bool IsActive { get; set; }
    }
}