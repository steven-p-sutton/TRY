using System;
using Moq;
using Mock;

namespace nsEmployee
{
    public class MEmployee : IMock
    {
        public Mock<Employee> _mMock;
        public MEmployee()
        {
            _mMock = new Mock<Employee>();
        }
        public Mock<Employee> Mock
        {
            get => _mMock;
        }
        public override bool Returns
        {
            set
            {
                if (value)
                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                     .Returns((int x) => DateTime.Now);
                else
                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                     .Returns((int x) => DateTime.MinValue);
            }
        }
        public override bool ReturnsAsync
        {
            set
            {
                if (value)
                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
                else
                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
            }
        }
        public override bool Verifyable
        {
            set
            {
                if (value)
                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Verifiable();
                else
                    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
            }
        }
        public override int Verify
        {
            set
            {
                if (value == 0)
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Never());
                else if (value == 1)
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Once());
                else
                    _mMock.Verify(x => x.GetDateOfJoining(It.IsAny<int>()), Times.Exactly(value));
            }
        }
        public override void Throws(Exception exception, string message)
        {
            _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
            .Throws(new Exception(message));

            this.message = message;
        }
        public override void Setup()
        {
            this.Verifyable = true;
            this.Returns = true;
            // this.Throws(new Exception(), "Hello world");
        }
        public override void Run()
        {
            Console.WriteLine(this.Mock.Object.GetDateOfJoining(1));
        }
        public override void Assert()
        {
            this.Verify = 1;
        }
    }
}
