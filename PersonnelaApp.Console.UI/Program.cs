using PersonnelApp.Dal;
using PersonnelApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelaApp.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            unitOfWork.DepartmentRepository.Add(new Department() {Name="Bilgi İşlem",IsActive=true,CreateDate=DateTime.Now });
            unitOfWork.DepartmentRepository.Add(new Department() { Name = "Muhasebe", IsActive = true, CreateDate = DateTime.Now });
            unitOfWork.Complete();
        }
    }
}
