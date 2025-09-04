using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevExWithEntity.Business.Managers
{
    public class EmailManager : IEmailService
    {
        private readonly IEmailDAL _emailDAL;

        public EmailManager(IEmailDAL emailDAL)
        {
            _emailDAL = emailDAL;
        }

        public void Add(Email t)
        {
            _emailDAL.Add(t);
        }

        public void Delete(Email t)
        {
            _emailDAL.Delete(t);
        }

        public Email GetById(int Id)
        {
            return _emailDAL.GetById(Id);
        }

        public List<Email> List(Expression<Func<Email, bool>> filter = null, Func<IQueryable<Email>, IOrderedQueryable<Email>> orderBy = null, int? take = null)
        {
            return _emailDAL.List(filter, orderBy, take);
        }

        public List<Email> ListAll()
        {
            return _emailDAL.ListAll();
        }

        public void Update(Email t)
        {
            _emailDAL.Update(t);
        }
    }
}
