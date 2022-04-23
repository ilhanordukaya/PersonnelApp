using PersonnelApp.Dal.Repositories.Abstract;
using PersonnelApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal.Repositories.Concrete
{
    public class PersonnelRepository : Repository<Personel>, IPersonnelRepository
    {
        public PersonnelRepository(PersonnelContext context):base(context)
        {

        }
        public IEnumerable<Personel> GetPersonnelsWithDepartments()
        {
            return PersonnelContext.Personels.Include("Departments").ToList();
        }
        public PersonnelContext PersonnelContext { get {return _context as PersonnelContext; } }
    }
}
