using Moq;
using Conductus.MOCK.Model.Core;

namespace Conductus.EXAMPLE.Model
{
    public class MExample : IMock
    {
        public new enum VerifyTimes { NEVER = 0, ONCE = 1, FAIL_Add = 4, FAIL_Find = 5, FAIL_Remove = 6 };

        public Mock<IExample> _mMock;
        public MExample()
        {
            _mMock = new Mock<IExample>();
        }
        public Mock<IExample> Mock
        {
            get => _mMock;
        }
        public override bool Returns
        {
            set
            {
                if (this.Run == RunType.SUCCESS)
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()))
                     .Returns(0);

                    _mMock.Setup(x => x.Find(It.IsAny<string>()))
                    .Returns(0);

                    _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                    .Returns("Mock");
                }
                else
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()))
                     .Returns(int.MinValue);

                    _mMock.Setup(x => x.Find(It.IsAny<string>()))
                    .Returns(int.MinValue);

                    _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                    .Returns(string.Empty);
                }
            }
        }
        public override bool ReturnsAsync
        {
            set
            {
                if (this.Run == RunType.SUCCESS)
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()));
                    _mMock.Setup(x => x.Find(It.IsAny<string>()));
                    _mMock.Setup(x => x.Remove(It.IsAny<int>()));
                }
                else
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()));
                    _mMock.Setup(x => x.Find(It.IsAny<string>()));
                    _mMock.Setup(x => x.Remove(It.IsAny<int>()));
                }
            }
        }
        public override bool Verifyable
        {
            set
            {
                if (value)
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()))
                    .Verifiable();

                    _mMock.Setup(x => x.Find(It.IsAny<string>()))
                    .Verifiable();

                    _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                    .Verifiable();
                }
                else
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()));
                    _mMock.Setup(x => x.Find(It.IsAny<string>()));
                    _mMock.Setup(x => x.Remove(It.IsAny<int>()));
                }
            }
        }
        public override int Verify
        {
            set
            {
                if (value == (int)VerifyTimes.NEVER)
                {
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
                }
                else if (value == (int)VerifyTimes.ONCE)
                {
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Once());
                }
                else if (value == (int)VerifyTimes.FAIL_Add)
                {
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Once());
                }
                else if (value == (int)VerifyTimes.FAIL_Find)
                {
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Once());
                }
                else if (value == (int)VerifyTimes.FAIL_Remove)
                {
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Once());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Once());
                }
                else
                {
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Exactly(value));
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Exactly(value));
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Exactly(value));
                }
            }
        }
        public override RunType Throws
        {
            set
            {
                if (value == RunType.EXCEPTION)
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);

                    _mMock.Setup(x => x.Find(It.IsAny<string>()))
                    .Throws(this.ExceptionExpected);

                    _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                    .Throws(this.ExceptionExpected);
                }
                else
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()));
                    _mMock.Setup(x => x.Find(It.IsAny<string>()));
                    _mMock.Setup(x => x.Remove(It.IsAny<int>()));
                }
            }
        }
        public override RunType Arrange
        {
            set
            {
                if (value == RunType.SUCCESS)
                {
                    this.Verifyable = true;
                    this.Returns = true;
                }
                else
                {
                    this.Throws = value;
                }
            }
        }
        public override RunType Test
        {
            set
            {
                this.Mock.Object.Add("Item");
                this.Mock.Object.Remove(this.Mock.Object.Find("Item"));
            }
        }
        public override RunType Assert
        {
            set
            {
                if (value == RunType.SUCCESS)
                {
                    this.Verify = (int)VerifyTimes.ONCE;
                }
                else
                {
                    this.Verify = (int)VerifyTimes.ONCE;
                }
            }
        }
    }
}
