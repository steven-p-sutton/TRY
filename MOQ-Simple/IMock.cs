using Moq;
using nsEmployee;

namespace Mock
{
    public class IMock
    {
        public Mock<Employee> _mMock;
        public IMock()
        {
            _mMock = new Mock<Employee>();
        }
        public Mock<Employee> Mock
        {
            get => _mMock;
        }
        public virtual bool Verifyable { set; get; }
        public virtual bool Returns { set; get; }
        public virtual int Verify { set; get; }
    }
}
