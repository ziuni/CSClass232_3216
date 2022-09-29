using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class UseClass21_2
    {
        static void Main(string[] args)
        { 
            //Random 클래스를 사용한 임의의 정수 생성
            Random random = new Random();
            Console.WriteLine(random.Next(10));
            Console.WriteLine(random.Next(10));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100) + "\n");

            //임의의 실수 생성
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() + "\n");

            //원하는 범위의 실수 난수 생성
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10 + "\n");

            //////////////////////////////////////////////////////////////////////////////

            // List 클래스
            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArrary = new string[10];
            //배열의 크기를 바꾸기 위해선 배열을 새로 생성해야함.

            List<int> list = new List<int>();
            // List를 사용하면 크기가 가변적인 배열을 만들 수 있음. 
            // 리스트를 선언할 때 어떤 자료형인지 알려주기 위해 제네릭(Generic) 사용
            // 제네릭은 클래스 이름 뒤에 <>으로 감싸서 적용.

            list.Add(52);
            list.Add(273);
            list.Add(3216);
            list.Add(64);

            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }

            Console.WriteLine();

            //리스트 인스턴스 생성과 동시에 요소 추가
            List<int> instance = new List<int>() { 16, 3216, 3215, 404 };
            foreach (var item in instance)
            {
                Console.WriteLine("Count: " + instance.Count + "\titem: " + item);
            }

            Console.WriteLine();

            //리스트 요소 삭제
            List<int> removeEx = new List<int>() { 16, 404, 3216, 151 };
            removeEx.Remove(16);
            foreach (var item in removeEx)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }

            //////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();

            Console.WriteLine("절대값 : " + Math.Abs(-3.1415));
            Console.WriteLine("크거나 같은 최소 정수 : " + Math.Ceiling(3.1415));
            Console.WriteLine("작거나 같은 최대 정수 : " + Math.Floor(3.1415));
            Console.WriteLine("두개중에 더 큰거 : " + Math.Max(3.1415, 54.321));
            Console.WriteLine("두개중에 더 작은거 : " + Math.Min(123.4, 124.3));
            Console.WriteLine("반올림 : " + Math.Round(3.5415));
            Console.WriteLine("소수점 둘째 자리에서 반올림 : " + Math.Round(Math.PI, 2));
        }
    }
}
