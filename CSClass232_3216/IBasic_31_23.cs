using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//31-2
namespace InterfaceBasic
{
    interface IBasic
    {
        int TestInstanceMethod();
        int TestProperty { get; set; }
    }
}
