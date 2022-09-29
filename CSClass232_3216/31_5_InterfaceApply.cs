using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"C:\Users\pc220\Documents\visual studio 2012\Projects\ConsoleApplication1\ConsoleApplication1\test.txt", "문자열을 파일에 씁니다.");
            Console.WriteLine(File.ReadAllText(@"C:\Users\pc220\Documents\visual studio 2012\Projects\ConsoleApplication1\ConsoleApplication1\test.txt"));

            //StreamWriter writer = new StreamWriter()

            using (StreamWriter writer = new StreamWriter(@"C:\Users\pc220\Documents\visual studio 2012\Projects\ConsoleApplication1\ConsoleApplication1\test.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("StreamWriter 클래스를 사용해");
                writer.WriteLine("글자를 여러 줄 입력해봅니다.");

                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("반복문 - " + i);
                }

            }
        }//main

    }
}
