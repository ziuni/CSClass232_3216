using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Interface
    {
        class Dummy : IDisposable
        {

            public void Dispose()
            {
                Console.WriteLine("Dispose() 메소드를 호출합니다.");
            }
        }//class 

        static void Main(string[] args)
        {
            Dummy dummy = new Dummy();
            dummy.Dispose();

            using(Dummy dummy2 = new Dummy());

        }//Main
    }//class Program
}//namespace