using MVCEmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MVCEmployeeManagement.EF.Mappings
{
    public class DepartmentMap
    {
        public static void Map(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<Department> entity = modelBuilder.Entity<Department>();

            entity.HasKey(x => x.ID);
            entity.Property(d => d.Name).IsRequired().HasMaxLength(50);
            entity.Property(d => d.Description).IsOptional().HasMaxLength(500);

            //entity.HasMany(d => d.Employees)
            //    .WithRequired(e => e.Department);
                
        }
    }
}