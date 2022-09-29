using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceBasic
{
    class TestClass { }

    //delegate void TestDelegate();

    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price) {
            Name = name;
            Price = price;
        }
    }

    //---- 클래스 외부에 선언 가능
    public delegate void TestDelegateA();

    public delegate void TestDelegate();

    // 델리게이트 활용
    //델리게이터를 활용하는 대표적인 형태는 콜백 메서드(callback method). 매개변수로 전달하는 메서드?
    public delegate void CustomDelegate();
    
    //public void Method(CustomDelegate cd){ cd(); } //클래스 대리자 열거형 인터페이스 또는 구조체가 필요합니다. ?

    //****
    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }

        public Student(string name, double score)
        {
            this.Name = name;
            this.Score = score;
        }

        public override string ToString() //ToString() 메서드 오버라이딩
        {
            return this.Name + " : " + this.Score;
        }
    }

    class Students
    {
        private List<Student> listOfStudent = new List<Student>();
        public delegate void PrintProcess(Student list); // 델리게이터 선언
        public void Add(Student student) 
        {
            listOfStudent.Add(student);
        }
        public void Print()
        {
            Print((student) => //아래에 선언한 Print(PrintProcess process) 메서드를 사용해 선언한 메서드. 별다른 출력방식을 지정하지 않았을 경우 Console.WriteLine()메서드로 단순 출력
                {
                    Console.WriteLine(student);
                });
        }

        public void Print(PrintProcess process) //콜백 메서드 사용
        {
            foreach (var item in listOfStudent)
            {
                process(item); //콜백 메서드에 매개변수를 전달해 호출
            }
        }
    }

    class Program
    {
        //---- 클래스 내부에 선언 가능
        public delegate void TestDelegateB();

        //$$$$$
        public delegate void SendString(string message);

        static void Main(string[] args) {
            TestClass testclass = new TestClass();
            
            //TestDelegate testdelegate = <메서드 이름, 무명 델리게이터(anonymous delegator), 람다> //델리게이터 변수를 초기화하는 방법

            List<Product> products = new List<Product>() 
            {
                new Product("감자탕", 500), new Product("닭도리탕", 1000), new Product("사약", 450), new Product("곰탕", 2000)
            };

            //정렬
            products.Sort(SortWithPrice);

            //출력
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            Console.WriteLine("---------------------------------------");

            //무명 델리게이터 기본
            //리스트 생성
            List<Product> ananydelist = new List<Product>()
            {
                   new Product("피카츄", 500), new Product("꼬부기", 1200), new Product("파이리", 300), new Product("이상해씨", 1000)
            };

            //정렬
            ananydelist.Sort(delegate(Product a, Product b)
            {
                return a.Price.CompareTo(b.Price);
            });

            //출력
            foreach (var item in ananydelist)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            Console.WriteLine("---------------------------------------");

            //람다 기본
            //(<매개변수>, <매개변수>) => {
            //    //코드
            //    return 반환
            //}
            //메서드 내부에 입력할 코드가 딱히 없다면 짧게 입력할 수도 있음
            //(ananydelist, b) => 반환

            //람다 기본 예제
            List<Product> lambdalist = new List<Product>()
            {
                   new Product("a", 500), new Product("b", 1200), new Product("c", 300), new Product("d", 1000)
            };

            lambdalist.Sort((a, b) =>
            {
                return a.Price.CompareTo(b.Price);
            });

            // 더 간단한 람다
            //lambdalist.Sort((a, b) => a.Price.CompareTo(b.Price));

            foreach (var item in lambdalist)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            Console.WriteLine("---------------------------------------");

            // 무명 델리게이터를 사용한 이벤트 연결
            //winform delegatorTest

            //델리게이터 선언
            //무명 델리게이터랑 델리게이터는 다름. 이름이 있는 델리게이터임. 왜 유명 델리게이터가 아닌가요
            //델리게이터는 자료형. 클래스를 선언할 수 있는 위치라면 어디든 선언할 수 있음.

            // 델리게이터 형식 지정
            //[접근 제한자] delegate [반환형] [델리게이터 이름]([매개변수]);
            //----델리게이터 선언
            //델리게이터를 자료형으로 변수 선언 가능
            TestDelegateA deleA;
            TestDelegateB deleB;

            // 초기화 방법
            TestDelegate delegateA = TestMethod; //메서드 이름을 사용한 초기화
            TestDelegate delegateB = delegate() { };//무명 델리게이터를 사용한 초기화
            TestDelegate delegateC = () => { };//람다를 사용한 초기화

            //델리게이터는 일반 메서드처럼 호출 할 수 있음.
            delegateA();
            delegateB();
            delegateC();

            //****콜백메서드
            Students students = new Students();
            students.Add(new Student("이지은", 4.2));
            students.Add(new Student("이수연", 4.4));

            students.Print(); //단순출력
            students.Print((student) =>//출력 방식을 별도로 지정한 출력
            {
                Console.WriteLine();
                Console.WriteLine("이름 : " + student.Name);
                Console.WriteLine("학점 : " + student.Score);
            });

            Console.WriteLine("---------------------------------------");

            //33-4 델리게이터연산
            //$$$$$
            SendString sayHello, sayGoodbye, multiDelegate;

            sayHello = Hello;
            sayGoodbye = GoodBye;

            multiDelegate = sayHello + sayGoodbye; //멀티델리게이트는 두개의 델리게이터 변수가 합쳐진 것
            multiDelegate("이름");//이런 델리게이터 변수를 호출하면 두개의 메서드가 모두 호출됩니다.

            Console.WriteLine();

            multiDelegate -= sayGoodbye; //멀티델리게이트에서 세이굿바이를 제거
            multiDelegate("이름"); //세이헬로우, 즉 하나의 메서드만 호출됨.

            Console.WriteLine("---------------------------------------");

            //#####함께하는 응용예제 - 스레드
            //스레드 생성하기
            //스레드를 생설할 때는 Thread 클래스를 사용. Thread 클래스의 생성자 매개변수에는 이번 장에서 배운 메서드 이름, 무명 델리게이터, 람다를 넣을 수 있음.
            //Thread threadA = new Thread(TestMethod);
            //Thread threadB = new Thread(delegate()
            //{

            //});
            //Thread threadC = new Thread(() =>
            //{

            //});

            //스레드 실행
            //Start() 메서드로 실행. 람다를 사용해서 3개 만들고 실행해보자
            Thread threadA = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                    Console.Write("A");
            });
            Console.WriteLine();
            Thread threadB = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                    Console.Write("B");
            });
            Console.WriteLine();
            Thread threadC = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                    Console.Write("C");
            });
            threadA.Start();
            threadB.Start();
            threadC.Start();


        }//main

        private static int SortWithPrice(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }

        //comparison이라는 델리게이터
        public delegate int Comparison<in T>(T x, T y);

        ////무명 델리게이터
        //delegate(<매개변수>, <매개변수>){
        //    //코드
        //    return 반환
        //}

        static void TestMethod() { }

        //$$$$$
        public static void Hello(string message) {
            Console.WriteLine("안녕하세여 " + message + " 씨");
        }

        public static void GoodBye(string message) {
            Console.WriteLine("안녕히가세요 " + message + " 씨");
        }
    }//class prgram
}//namespace
