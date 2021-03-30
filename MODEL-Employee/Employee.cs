using System;

namespace Conductus.MODEL.EMPLOYEE
{
    public class Employee : IEmployee
    {
        private string _name;
        private DateTime _dateOfJoining;

        public Employee(string name, DateTime dateOfJoining)
        {
            _name = name;
            _dateOfJoining = dateOfJoining;
        }
        public string Name() { return _name; }
        public virtual DateTime GetDateOfJoining(int id) { return _dateOfJoining; }
    } 
}