using PersonnelApp.Dal.Repositories.Abstract;
using PersonnelApp.Dal.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal
{
    public class UnitOfWork : IUnitOfWorks
    {
        protected PersonnelContext _personnelContext;
        public UnitOfWork(PersonnelContext context)
        {
            _personnelContext = context;
            DepartmentRepository = new DepartmentRepository(_personnelContext);
            PersonnelRepository = new PersonnelRepository(_personnelContext);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IPersonnelRepository PersonnelRepository { get; private set; }

        public int Complete()
        {
            return _personnelContext.SaveChanges();
        }

        public void Dispose()
        {
            _personnelContext.Dispose();
        }
    }
}
