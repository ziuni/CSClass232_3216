/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////12-2
            //Console.WriteLine("Hello C# World");
            //Console.Write("Hello write!");

            ////12-9
            //string input = Console.ReadLine();
            //Console.WriteLine("input : " + input);

            ////12-10
            //Console.WriteLine((52).ToString());
            //Console.WriteLine((52.273).ToString());
            //Console.WriteLine(('a').ToString());
            //Console.WriteLine((true).ToString());
            //Console.WriteLine((false).ToString());

            //Console.WriteLine();

            //Console.WriteLine((52).ToString().GetType());
            //Console.WriteLine((52.273).ToString().GetType());
            //Console.WriteLine(('a').ToString().GetType());
            //Console.WriteLine((true).ToString().GetType());
            //Console.WriteLine((false).ToString().GetType());

            //Console.WriteLine();

            //double number = 31.41592;
            //Console.WriteLine(number.ToString("0.0"));
            //Console.WriteLine(number.ToString("0.00"));
            //Console.WriteLine(number.ToString("0.000"));
            //Console.WriteLine(number.ToString("0.0000"));
            ////참고로 잘려나간 부분은 반올림됨.

            //Console.WriteLine();

            //Console.WriteLine(31 + 415);
            //Console.WriteLine("31" + 415);
            //Console.WriteLine(31 + "415");
            //Console.WriteLine("31" + "415");

            //int number = 52273;
            //string outputA = number + "";
            //Console.WriteLine(outputA);
            //Console.WriteLine();
            //int character = 'a';
            //string outputB = character + "";
            //Console.WriteLine(outputB);

            //Console.WriteLine(bool.Parse("True"));
            //Console.WriteLine(bool.Parse("true"));
            //Console.WriteLine(bool.Parse("False"));
            //Console.WriteLine(bool.Parse("false"));
            //Console.WriteLine();
            //Console.WriteLine(bool.Parse("True").GetType());
            //Console.WriteLine(bool.Parse("true").GetType());
            //Console.WriteLine(bool.Parse("False").GetType());
            //Console.WriteLine(bool.Parse("false").GetType());

            //13-1
            //int time = DateTime.Now.Hour;
            //Console.WriteLine(time);
            //if (time < 12)
            //    Console.WriteLine("오전입니다");
            //else
            //    Console.WriteLine("오후입니다.");

            //13-5
            //Console.Write("몇시인가요?(0~23) : ");
            //int time = int.Parse(Console.ReadLine());
            //switch (time)
            //{
            //    case 0:
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //    case 5:
            //    case 6:
            //    case 7:
            //    case 8:
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("오전입니다.");
            //        break;

            //    case 12:
            //    case 13:
            //    case 14:
            //    case 15:
            //    case 16:
            //    case 17:
            //    case 18:
            //    case 19:
            //    case 20:
            //    case 21:
            //    case 22:
            //    case 23:
            //        Console.WriteLine("오후입니다.");
            //        break;

            //    default:
            //        Console.WriteLine("오전도 오후도 아닙니다.");
            //        break;
            //        //break 안 쓰면 오류남...
            //}

            ////13-6
            //            Console.Write("숫자를 입력하세요 : ");
            //            int number = int.Parse(Console.ReadLine());
            //            Console.WriteLine(number % 2 == 0 ? "짝" : "홀");

            //13-7
            //Console.Write("'안녕'으로 인사하세요 : ");
            //string line = Console.ReadLine();
            //if (line.Contains("안녕"))
            //    Console.WriteLine("안녕하세요");
            //else
            //    Console.WriteLine(";ㅅ;");

            //Console.Write("방향키 입력 : ");
            //ConsoleKeyInfo info = Console.ReadKey();
            //Console.WriteLine();
            //switch (info.Key)
            //{
            //    case ConsoleKey.UpArrow:
            //        Console.WriteLine("위로 이동");
            //        break;
            //    case ConsoleKey.DownArrow:
            //        Console.WriteLine("아래로 이동");
            //        break;
            //    case ConsoleKey.LeftArrow:
            //        Console.WriteLine("왼쪽으로 이동");
            //        break;
            //    case ConsoleKey.RightArrow:
            //        Console.WriteLine("오른쪽으로 이동");
            //        break;
            //    default:
            //        Console.WriteLine("다른 키를 눌렀습니다.");
            //        break;
            //}

            //14-10
            ////1 대문자화와 소문자화
            //string input = "Potato Tomato";
            //Console.WriteLine(input.ToUpper());
            //Console.WriteLine(input.ToLower());
            //input.ToUpper();
            //Console.WriteLine(input);
            ////ToUpper() 과 ToLower()은 비파괴적 메소드라서 변경되지 않고 반환만 함.

            ////2 문자열 자르기
            //string input = "감자 고구마 토마토";
            //string[] inputs = input.Split(new char[]{' '});
            ////대괄호 inputs 뒤에다 놓으면 오류남...?
            //Console.WriteLine(input + "\n");
            //foreach (var item in inputs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //string[] inputs2 = input.Split((new string[] { " " }), StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in inputs)
            //{
            //    Console.WriteLine(item);
            //}

            ////3 문자열 양 옆의 공백 제거
            //string input = "        test\n";
            //Console.WriteLine("::" + input.Trim() + "::" + "\n");
            //Console.WriteLine("::" + input.TrimStart() + "::" + "\n");
            //Console.WriteLine("::" + input.TrimEnd() + "::" + "\n");

            ////4 배열을 문자열로 변환
            //string[] array = { "딸기", "사과", "바나나", "포도" };
            //Console.WriteLine(string.Join(" / ", array));

            ////5 콘솔 제어 메서드
            //Console.Write("메서드 호출 전");
            //Console.SetCursorPosition(10, 10);
            //Console.WriteLine("메서드 호출 후");
            //Console.WriteLine();

            //Console.WriteLine("첫번째 출력");
            //Thread.Sleep(1000);
            //Console.WriteLine("두번째 출력");
            //Thread.Sleep(1000);
            //Console.WriteLine("세번째 출력");

            ////namespace WhileLoop
            //int x = 1;
            //while (x < 50) 
            //{ 
            //    //화면을 지우고 커서를 이동합니다.
            //    Console.Clear();
            //    Console.WriteLine(x);
            //    Console.SetCursorPosition(x, 5);

            //    //출력
            //    if (x % 3 == 0)
            //        Console.WriteLine("__@");
            //    else if (x % 3 == 1)
            //        Console.WriteLine("_+@");
            //    else
            //        Console.WriteLine("+_@");

            //    //100밀리초 정지 후 x를 증가시킴
            //    Thread.Sleep(100);
            //    x++;
            //}
            //Console.WriteLine(x);

            ////switch 조건문과 무한 반복문
            //Console.WriteLine("X(x)를 눌러도 꺼지지 않습니다.");
            //while (true)
            //{
            //    ConsoleKeyInfo info = Console.ReadKey();
            //    switch (info.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            Console.WriteLine("위방향키");
            //            break;
            //        case ConsoleKey.DownArrow:
            //            Console.WriteLine("아래방향키");
            //            break;
            //        case ConsoleKey.LeftArrow:
            //            Console.WriteLine("왼쪽방향키");
            //            break;
            //        case ConsoleKey.RightArrow:
            //            Console.WriteLine("오른쪽방향키");
            //            break;
            //        case ConsoleKey.X:
            //            break;
            //    }

            //}

            ////개선된 switch 조건문(자주 애용되는 패턴)
            //Console.WriteLine("X(x)를 누르면 꺼집니다.");
            //bool state = true;
            //while (state) 
            //{
            //    ConsoleKeyInfo info = Console.ReadKey();
            //    switch (info.Key) 
            //    { 
            //        case ConsoleKey.UpArrow:
            //            Console.WriteLine("위로 이동");
            //            break;
            //        case ConsoleKey.DownArrow:
            //            Console.WriteLine("아래로 이동");
            //            break;
            //        case ConsoleKey.LeftArrow:
            //            Console.WriteLine("왼쪽으로 이동");
            //            break;
            //        case ConsoleKey.RightArrow:
            //            Console.WriteLine("오른쪽으로 이동");
            //            break;

            //        case ConsoleKey.X :
            //            state = false;
            //            break;
            //    }
            //}



        }
    }
}
