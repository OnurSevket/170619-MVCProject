﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEmployeeManagement.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}