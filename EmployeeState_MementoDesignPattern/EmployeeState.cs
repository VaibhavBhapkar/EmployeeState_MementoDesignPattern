using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeState_MementoDesignPattern
{
    public class EmployeeState
    {
        public string Designation { get; set; }
        public string Name { get; set; }
        public EmployeeState(string Designation, string Name)
        {
            this.Designation = Designation;
            this.Name = Name;
        }
        public string GetDetails()
        {
            return "Employee [Name=" + Name + ", Designation=" + Designation+"]";
        }
    }
}
