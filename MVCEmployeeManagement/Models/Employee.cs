using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEmployeeManagement.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<DateTime> HireDate { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public int DepartmentID { get; set; }

        // NAV PROP

        public virtual Department Department { get; set; }

    }
}