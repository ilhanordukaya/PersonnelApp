using PersonnelApp.Dal.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal
{
   public interface IUnitOfWorks:IDisposable
    {
        IDepartmentRepository DepartmentRepository { get; }
        IPersonnelRepository PersonnelRepository { get; }

        int Complete();
       
    }
}
