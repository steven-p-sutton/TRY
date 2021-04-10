using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Conductus.MOCK.Model.Core;

namespace Conductus.EXAMPLE.Model
{
    public class MExample : IMock
    {
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
                    _mMock.Setup(o => o.Add(It.IsAny<string>()))
                     .Returns((int x) => 0);

                    _mMock.Setup(o => o.Find(It.IsAny<string>()))
                    .Returns((int x) => 0);

                    _mMock.Setup(o => o.Remove(It.IsAny<int>()))
                    .Returns((string x) => "Item");
                }
                else
                {
                    _mMock.Setup(x => x.Add(It.IsAny<string>()))
                     .Returns((int x) => int.MinValue);

                    _mMock.Setup(x => x.Find(It.IsAny<string>()))
                    .Returns((int x) => int.MinValue);

                    _mMock.Setup(x => x.Remove(It.IsAny<int>()))
                    .Returns((string x) => "");
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
                if (value == 0)
                {
                    _mMock.Verify(x => x.Add(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Find(It.IsAny<string>()), Times.Never());
                    _mMock.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
                }
                else if (value == 1)
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
                //if (value == RunType.EXCEPTION)
                //    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()))
                //    .Throws(this.ExceptionExpected);
                //else
                //    _mMock.Setup(x => x.GetDateOfJoining(It.IsAny<int>()));
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
                    this.Throws = value;
            }
        }
        public override RunType Test
        {
            set
            {
                this.Mock.Object.Find("Item");
                var idx = this.Mock.Object.Add("Item");
                this.Mock.Object.Remove(idx);
            }
        }
        public override RunType Assert
        {
            set
            {
                if (value == RunType.SUCCESS)
                    this.Verify = 1;
                else
                    this.Verify = 1;
            }
        }
    }
}
