using System;
using Newtonsoft.Json;

namespace Conductus.MODEL.EMPLOYEE
{
    public class Employee : IEmployee
    {
        public virtual DateTime GetDateOfJoining(int id) { throw new NotImplementedException(); }
    }
}
