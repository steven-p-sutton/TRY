
#if _csSharedClass_
#else
#define _csSharedClass_
    public class csSharedClass
    {
        private string _sSharedClass = "csSharedClass";
        public string sSharedClass
        {
            get { return _sSharedClass; }
            set { _sSharedClass = value; }
        }
    }
#endif
