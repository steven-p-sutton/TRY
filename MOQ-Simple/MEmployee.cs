using System;
using Moq;

namespace MOQ_Simple
{
    public class MEmployee
    {
        public Mock<Employee> _mEmployee;

        public MEmployee()
        {
            _mEmployee = new Mock<Employee>();
        }
        public Mock<Employee> Mock
        {
            get => _mEmployee;
        }
        public bool Returns
        {
            set =>
               _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Returns((int x) => DateTime.Now);
        }
        public bool Verifyable
        {
            set =>
                _mEmployee.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Verifiable();
        }
        public int Verify
        {
            set
            {
                if (value == 0)
                    _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never());
                else if (value == 1)
                    _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Once());
                else
                    _mEmployee.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Exactly(value));
            }
        }
    }
}
