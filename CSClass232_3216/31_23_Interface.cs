using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic
{
    interface ITest
    { 
    }

    class TestClass : IBasic
    {
        public int TestInstanceMethod()
        {
            throw new NotImplementedException();
        }

        public int TestProperty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
    class Interface2
    {
        static void Main(string[] args)
        {
            IBasic basic = new TestClass();
        }
    }
}
