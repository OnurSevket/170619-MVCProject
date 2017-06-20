using MVCEmployeeManagement.EF.Mappings;
using MVCEmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCEmployeeManagement.EF
{
    public class DataContext : DbContext
    {
        public DataContext() : base("NeptuneEmpDb")
        {

        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }


        // Model nedir ?
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            DepartmentMap.Map(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }


    }

}