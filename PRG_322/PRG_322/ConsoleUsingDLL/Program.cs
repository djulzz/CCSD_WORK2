using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using external_library;

namespace ConsoleUsingDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account a = new Account();
            Console.WriteLine("Before calling the dll");
            external_library.DLL.DLL_Run();
            Console.WriteLine("After calling the dll");
        }
    }
}
