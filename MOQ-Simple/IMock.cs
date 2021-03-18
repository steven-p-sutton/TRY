namespace Mock
{
    public abstract class IMock
    {
        public abstract bool Verifyable { set; }
        public abstract bool Returns { set; }
        public abstract int Verify { set; }
    }
}
