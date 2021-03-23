using System;
using Newtonsoft.Json;

namespace nsEmployee
{
    public class Employee : IEmployee
    {
        public virtual DateTime GetDateOfJoining(int id) { throw new NotImplementedException(); }
    }
}
