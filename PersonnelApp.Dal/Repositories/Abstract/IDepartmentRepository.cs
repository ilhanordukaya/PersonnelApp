﻿using PersonnelApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal.Repositories.Abstract
{
   public interface IDepartmentRepository:IRepository<Department>
    {
        IEnumerable<Department>  GetTopDepartments(int count);
        IEnumerable<Department> GetDepartmentsWithPersonnels();

    }
}
