using MVCEmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MVCEmployeeManagement.EF.Mappings
{
    public class EmployeeMap :EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            HasKey(e =>e.ID);

            Property(e => e.FirstName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(e => e.LastName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(e => e.Phone)
                .HasMaxLength(20);
            Property(e => e.HireDate)
                .HasColumnType("date").IsOptional();
            Property(e => e.DateOfBirth)
                .HasColumnType("date").IsOptional();

            Property(e => e.Email).HasMaxLength(100);

            HasRequired(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentID)
                .WillCascadeOnDelete(false);



        }
    }
}