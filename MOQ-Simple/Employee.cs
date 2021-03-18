using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class Employee : IEmployee
    {
        public virtual DateTime GetDateOfJoining(int id) { throw new NotImplementedException(); }
    }
}
