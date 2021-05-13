using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeState_MementoDesignPattern
{
    public class Caretaker
    {
        private List<Memento> employeeStateList = new List<Memento>();
        public void AddMemento(Memento state)
        {
            employeeStateList.Add(state);
            Console.WriteLine("Employee state snapshots Maintained by CareTaker :" + state.GetDetails());
        }
        public Memento GetMemento(int index)
        {
            return employeeStateList[index];
        }
    }
}
