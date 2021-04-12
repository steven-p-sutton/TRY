using System;

namespace Conductus.EMPLOYEE.Model
{
    public class EEmployee : IEmployee
    {
        public string Name() { throw new EmployeeNotImplentedException(); }
        public virtual DateTime GetDateOfJoining(int id) { throw new EmployeeNotImplentedException(); }
    }
}
