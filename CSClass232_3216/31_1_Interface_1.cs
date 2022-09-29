using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class Product : IComparable
        //인터페이스를 상속해주지 않으면 호출이 안 됨.
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }

            public int CompareTo(object obj)
            {
                //throw new NotImplementedException();
                return this.Price.CompareTo((obj as Product).Price);
            }
        }//class Product

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() {Name="청사과", Price=1500},
                new Product() {Name="포도", Price=3000},
                new Product() {Name="딸기", Price=1000},
                new Product() {Name="귤", Price=2000},
            };
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
#region 결과
//처리되지 않은 예외: System.InvalidOperationException: 배열의 두 요소를 비교하지 못했습니다. ---> System.ArgumentException: 적어도 하나 이상의 개체가 IComparable을 구현해야 합니다.
//   위치: System.Collections.Comparer.Compare(Object a, Object b)
//   위치: System.Collections.Generic.ObjectComparer`1.Compare(T x, T y)
//   위치: System.Collections.Generic.ArraySortHelper`1.InsertionSort(T[] keys, Int32 lo, Int32 hi, IComparer`1 comparer)
//   위치: System.Collections.Generic.ArraySortHelper`1.IntroSort(T[] keys, Int32 lo, Int32 hi, Int32 depthLimit, IComparer`1 comparer)
//   위치: System.Collections.Generic.ArraySortHelper`1.IntrospectiveSort(T[] keys, Int32 left, Int32 length, IComparer`1 comparer)
//   위치: System.Collections.Generic.ArraySortHelper`1.Sort(T[] keys, Int32 index, Int32 length, IComparer`1 comparer)
//   --- 내부 예외 스택 추적의 끝 ---
//   위치: System.Collections.Generic.ArraySortHelper`1.Sort(T[] keys, Int32 index, Int32 length, IComparer`1 comparer)
//   위치: System.Array.Sort[T](T[] array, Int32 index, Int32 length, IComparer`1 comparer)
//   위치: System.Collections.Generic.List`1.Sort(Int32 index, Int32 count, IComparer`1 comparer)
//   위치: System.Collections.Generic.List`1.Sort()
//   위치: ConsoleApplication1.Program.Main(String[] args) 파일 c:\Users\pc220\Documents\Visual Studio 2012\Projects\ConsoleApplication1\ConsoleApplication1\31_1_Interface.cs:줄 31
//계속하려면 아무 키나 누르십시오 . . .
#endregion

        }//Main
    }//class Program
}//namespace