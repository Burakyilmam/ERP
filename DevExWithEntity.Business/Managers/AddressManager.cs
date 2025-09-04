using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Business.Managers
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDAL _addressDAL;

        public AddressManager(IAddressDAL addressDAL)
        {
            _addressDAL = addressDAL;
        }

        public void Add(Address t)
        {
            _addressDAL.Add(t);
        }

        public void Delete(Address t)
        {
            _addressDAL.Delete(t);
        }

        public Address GetById(int Id)
        {
            return _addressDAL.GetById(Id);
        }

        public List<Address> List(Expression<Func<Address, bool>> filter = null, Func<IQueryable<Address>, IOrderedQueryable<Address>> orderBy = null, int? take = null)
        {
            return _addressDAL.List(filter, orderBy, take);
        }

        public List<Address> ListAll()
        {
            return _addressDAL.ListAll();
        }

        public void Update(Address t)
        {
            _addressDAL.Update(t);
        }
    }
}
