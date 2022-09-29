using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqIntroduce
{
    /*리스트와 링큐 비교
    //class ListToLinq
    //{
    //    public List<int> ListTest()
    //    {
    //        List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //        List<int> output = new List<int>();
    //        foreach (var item in input)
    //        {
    //            if (item % 2 == 0)
    //            {
    //                output.Add(item);
    //            }
    //        }
    //        return output;
    //    }
    //    public 
    //    static void Main(string[] args)
    //    {
    //        List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //        var output = from item in input
    //               where item % 2 == 0
    //               select item;
    //    }
    //}*/
    
    /*//from in select 구문
    //1)
    //from<변수 이름(원하는 이름 지정)> in <컬렉션 이름>
    //select <결과에 넣을 요소>

    //2)
    //List<int><output> = new List<int>();
    //foreach(var <변수 이름 (원하는 이름 지정)> in <컬렉션 이름>)
    //{
    //    output.Add(<결과에 넣을 요소>);
    //}

    class fromInSelect
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var output = from item in input
                         select item * item; //원하는 형태로 값을 변환해서 결과를 만들수있음.

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }*/

    /*//where 구문
    //조건을 지정할 때 사용. where의 사용 위치에 주의.
    //1)
    //from <변수 이름(원하는 이름 지정)> in <컬렉션 이름>
    //where <조건식>
    //select <변수 이름(원하는 이름 지정)>

    //2)
    //List<int> <output> = new List<int>();
    //foreach(var <변수 이름(원하느 이름 지정)> in <컬렉션 이름>)
    //{
    //  if(조건식)
    //  {
    //      output.Add(<결과에 넣을 요소>);
    //  }
    //}

    class LinqWhere
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from item in input
                         where (item > 5) && (item % 2 == 0) //5보다 크면서 짝수
                         select item;
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }*/

    /*//orderby 구문
    //정렬 - 순서는 ascending(오름차순, abcd), descending(내림차순, dcba). 기본 정렬은 오름차순

    //from <변수 이름(원하는 이름 지정)> indexer <컬렉션 이름>
    //where <조건식>
    //orderby <정렬 대상> <정렬 순서>
    //select <변수 이름(원하는 이름 지정)>

    class OrderBy
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from item in input
                         where(item > 5) && (item % 2 == 0)//5보다 크면서 짝수
                         orderby item descending//내림차순
                         select item;
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }*/

    /*class ToArray_ToList
    {
        //ToArray() 메서드
        public int[] SelectEvenArray(int[] input)
        {
            return (from item in input
                    where item % 2 == 0
                    select item).ToArray<int>();
        }

        //ToList() 메서드
        public List<int> SelectEvenList(List<int> input)
        {
            return (from item in input
                    where item % 2 == 0
                    select item).ToList<int>();
        }
    }*/

}
