using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StructPrac
    {
        struct Point
        {
            public int x;
            public int y;
            public string testA; // 초기화되지 않은 멤버 변수는 생성자를 만든다면 반드시 생성자에서 초기화해줘야 한다.
            //public string testB = "init"; // 선언과 동시에 초기화할 수 없다. 오류가 발생함.

            public Point(int x, int y) //testA를 초기화하지 않으면 오류 발생
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
            }

            public Point(int x, int y, string testA)//생성자 오버로딩
            {
                this.x = x;
                this.y = y;
                this.testA = testA;
                //this.testB = testA;
            }
        }
        static void Main()
        {
            //Point point;
            //point.x = 10;
            //point.y = 10;
            Point point = new Point();

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
