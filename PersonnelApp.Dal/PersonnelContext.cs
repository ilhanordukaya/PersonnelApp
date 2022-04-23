using PersonnelApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal
{
    public class PersonnelContext:DbContext
    {
        public PersonnelContext():base("PersonnelContext")
        {

        }

        public  DbSet<Department> Deparments { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
