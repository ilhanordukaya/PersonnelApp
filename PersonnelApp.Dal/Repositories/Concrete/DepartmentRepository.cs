using PersonnelApp.Dal.Repositories.Abstract;
using PersonnelApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonnelContext context):base(context)
        {

        }
        public IEnumerable<Department> GetDepartmentsWithPersonnels()
        {
            return PersonnelContext.Deparments.Include("Personels").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonnelContext.Deparments.Take(count);
        }

        public PersonnelContext PersonnelContext { get { return _context as PersonnelContext; } }
    }
}
