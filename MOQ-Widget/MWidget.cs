using System;
using Moq;
using Mock;
using Conductus.WIDGET.Model.Core;

//public interface IWidget
//{
//    string Display(string title);
//    int Ping(int x, int y);
//}

namespace nsWidget
{
    public class MWidget : IMock
    {
        public Mock<WidgetObject> _mMock;
        public MWidget()
        {
            _mMock = new Mock<WidgetObject>();
        }
        public Mock<WidgetObject> Mock
        {
            get => _mMock;
        }
        public override bool Returns
        {
            set
            {
                if (value)
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                     .Returns((string x) => "Display called OK");

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                     .Returns((int x) => 42);
                }
                else
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                     .Returns((string x) => string.Empty);

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                     .Returns((int x) => 0);
                }
            }
        }
        public override bool ReturnsAsync
        {
            set
            {
                if (value)
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()));

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
                }
                else
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()));

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
                }
            }
        }
        public override bool Verifyable
        {
            set
            {
                if (value)
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()))
                    .Verifiable();

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
                    .Verifiable();
                }
                else
                {
                    _mMock.Setup(x => x.Display(It.IsAny<string>()));

                    _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()));
                }
            }
        }
        public override void Throws(Exception exception, string message)
        {
            _mMock.Setup(x => x.Display(It.IsAny<string>()))
            .Throws(new Exception(message));

            _mMock.Setup(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()))
            .Throws(new Exception(message));

            this.message = message;
        }
        public override int Verify
        {
            set
            {
                if (value == 0)
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Never());

                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Never());
                }
                else if (value == 1)
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Once());

                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Once());
                }
                else
                {
                    _mMock.Verify(x => x.Display(It.IsAny<string>()), Times.Exactly(value));

                    _mMock.Verify(x => x.Ping(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(value));
                }
            }
        }
    }
}
