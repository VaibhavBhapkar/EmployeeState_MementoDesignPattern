using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeState_MementoDesignPattern
{
    public class Memento
    {
        public EmployeeState employeeState { get; set; }
        public Memento(EmployeeState employeeState)
        {
            this.employeeState = employeeState;
        }
        public string GetDetails()
        {
            return "Memento [Employee State=" + employeeState.GetDetails() + "]";
        }
    }
}
