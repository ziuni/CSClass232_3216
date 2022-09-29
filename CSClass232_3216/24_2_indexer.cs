using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Products
    {
        public int this[int i]
        { 
            //Products products = new Products();
            //products[i]할때 호출
            get { return i; }
            //products[i] = 10 할때 호출
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }

    class SquareCalculator
    {
        public int this[int i]
        {
            get
            {
                return i * i;
            }
        }
    }
    class Indexer
    {
        static void Main(string[] args)
        {
            Products pro = new Products();
            Console.WriteLine(pro[1]);
            pro[1] = 100;

            SquareCalculator square = new SquareCalculator();
            Console.WriteLine(square[10]);
        }
    }
}
//배열 같은 클래스 Indexer