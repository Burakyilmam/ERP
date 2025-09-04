using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Entity
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }

        public bool IsActive { get; set; }
    }
}
