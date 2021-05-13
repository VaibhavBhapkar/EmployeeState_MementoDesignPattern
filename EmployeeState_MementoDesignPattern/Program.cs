
using System;

namespace EmployeeState_MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.employeeState = new EmployeeState("Software Engineer", "Vaibhav");
            Caretaker caretaker = new Caretaker();
            caretaker.AddMemento(originator.CreateMemento());
            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            originator.employeeState = new EmployeeState("Senior Software Engineer", "Vaibhav");
            caretaker.AddMemento(originator.CreateMemento());
            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.WriteLine("\nOriginator restoring to old state");
            originator.employeeState = caretaker.GetMemento(0).employeeState;
            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());


        }
    }
}
