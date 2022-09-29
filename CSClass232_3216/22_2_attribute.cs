using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        public int MyProperty { get; set; }//prop tab tab

        //propfull tab tab
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
        static void Main(string[] args)
        {

        }//Main
    }//Class1
}//namespace
