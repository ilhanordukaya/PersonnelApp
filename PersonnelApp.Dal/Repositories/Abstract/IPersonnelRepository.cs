using PersonnelApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal.Repositories.Abstract
{
   public interface IPersonnelRepository:IRepository<Personel>
    {

        IEnumerable<Personel> GetPersonnelsWithDepartments();
    }
}
