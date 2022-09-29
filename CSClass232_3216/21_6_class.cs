using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        //public string id;
        public string name;
        public int grade;
        //public string major;
        //public DateTime birthday;
        //변수만 갖고 있는 클래스를 모델 클래스라고 함.
    }
    class Class1
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "이지은", grade = 1 });
            list.Add(new Student() { name = "이수연", grade = 2 });
            list.Add(new Student() { name = "김효리", grade = 3 });
            list.Add(new Student() { name = "김민정", grade = 4 });
            list.Add(new Student() { name = "김찬희", grade = 1 });
            list.Add(new Student() { name = "공도윤", grade = 2 });
            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
            Console.WriteLine();

            //리스트와 모델 클래스 동시 초기화
            List<Student> listmodel = new List<Student>()
            {
                new Student() {name="이지은", grade = 1},
                new Student() {name="이수연", grade = 2},
                new Student() {name="김찬희", grade = 3},
                new Student() {name="김모리", grade = 4},
                new Student() {name="공도윤", grade = 1},
                new Student() {name="기묘리", grade = 2}
            };
            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
            Console.WriteLine();

            //List 클래스 요소 제거와 역 반복문
            List<Student> listrm = new List<Student>()
            {
                new Student() {name="이지은", grade = 1},
                new Student() {name="수수", grade = 2},
                new Student() {name="찬치", grade = 3},
                new Student() {name="모리", grade = 4},
                new Student() {name="라쿤", grade = 1},
                new Student() {name="묘리", grade = 2}
            };
            foreach (var item in listrm)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
            Console.WriteLine();

            //foreach (var item in listrm)//에러남. foreach반복문으론 요소 제거 불가능
            //{
            //    if (item.grade > 1)
            //    {
            //        listrm.Remove(item);
            //    }
            //}
            //Console.WriteLine();

            //for (int i = 0; i < listrm.Count; i++)// 동작이 이상함 지은1/찬치3/라쿤1 이렇게 남음.
            //{
            //    if (listrm[i].grade > 1)
            //        listrm.RemoveAt(i);
            //}

            for (int i = listrm.Count - 1; i >= 0; i--) //거꾸로 하면 잘 됨.
            {
                if (listrm[i].grade > 1)
                    listrm.RemoveAt(i);
            }

            foreach (var item in listrm)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
            Console.WriteLine();

        }//Main
    }//Class1
}//namespace
