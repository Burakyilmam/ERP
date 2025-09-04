using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Entity
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Surname { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(500)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string CustomerCode { get; set; }

        /// <summary>
        /// 0 - Person , 1 - Company
        /// </summary>
        public byte CustomerType { get; set; }

        [StringLength(50)]
        public string TaxNumber { get; set; }

        [StringLength(4096)]
        public string Notes { get; set; }

        public ICollection<Phone> Phones { get; set; }
        public ICollection<Email> Emails { get; set; }
        public ICollection<Address> Addresses { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }

        public bool IsActive { get; set; }
    }
}
