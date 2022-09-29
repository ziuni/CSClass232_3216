using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class PointClass
        {
            public int x;
            public int y;

            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct PointStruct
        {
            public int x;
            public int y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main()
        {
            //클래스
            PointClass pc1 = new PointClass(10, 20);
            PointClass pc2 = pc1;
            Console.WriteLine("pc1 : " + pc1.x + ", " + pc1.y);
            Console.WriteLine("pc2 : " + pc2.x + ", " + pc2.y);

            pc2.x = 100;
            pc2.y = 200;

            Console.WriteLine("pc1 : " + pc1.x + ", " + pc1.y);
            Console.WriteLine("pc2 : " + pc2.x + ", " + pc2.y);
            Console.WriteLine();

            //구조체
            PointStruct ps1 = new PointStruct(100, 200);
            PointStruct ps2 = ps1;
            Console.WriteLine("ps1 : " + ps1.x + ", " + ps1.y);
            Console.WriteLine("ps2 : " + ps2.x + ", " + ps2.y);

            ps2.x = 10;
            ps2.y = 20;

            Console.WriteLine("ps1 : " + ps1.x + ", " + ps1.y);
            Console.WriteLine("ps2 : " + ps2.x + ", " + ps2.y);
        }
    }
}
//클래스는 둘 다 값이 변하고 구조체는 넣은 것만 바뀜