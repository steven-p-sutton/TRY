using System;
using Moq;
using Mock;

namespace nsEmployee
{
    public class MEmployee : IMock
    {
        public override bool Returns
        {
            set =>
               _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Returns((int x) => DateTime.Now);
        }
        public override bool Verifyable
        {
            set =>
                _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                    .Verifiable();
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
    }
}
