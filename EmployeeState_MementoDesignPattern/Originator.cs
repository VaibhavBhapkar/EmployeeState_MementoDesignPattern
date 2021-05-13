using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeState_MementoDesignPattern
{
    public class Originator
    {
        public EmployeeState employeeState;

        public Memento CreateMemento()
        {
            return new Memento(employeeState);
        }
        public void SetMemento(Memento memento)
        {
            employeeState = memento.employeeState;
        }
        public string GetDetails()
        {
            return "Originator [Employee State=" + employeeState.GetDetails() + "]";
        }
    }
}
