using System;

namespace Conductus.EMPLOYEE.Model
{
    public class EEmployee : IEmployee
    {
        public string Name() { throw new NotImplementedException(); }
        public virtual DateTime GetDateOfJoining(int id) { throw new NotImplementedException(); }
    }
}
