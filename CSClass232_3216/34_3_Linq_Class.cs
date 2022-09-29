using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Class
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }

        //static void Main(string[] args)
        //{ 
        //    List<Product> input = new List<Product>()
        //    {
        //        new Product(){Name="고구마", Price=1500},
        //        new Product(){Name="사과", Price=1000},
        //        new Product(){Name="단호박", Price=2400},
        //        new Product(){Name="달걀", Price=4000},
        //        new Product(){Name="키위", Price=543},
        //        new Product(){Name="오렌지", Price=1500},
        //        new Product(){Name="자두", Price=2211},
        //        new Product(){Name="감자", Price=8888}
        //    };

        //    var output = from item in input
        //                 where item.Price > 1500
        //                 orderby item.Name descending //오름차순은 생략해도 됨 이건 내림차순
        //                 select item;
        //    foreach (var item in output)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
