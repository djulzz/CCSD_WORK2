using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Interfacing_01;

namespace ConsoleThough2
{
    class Program
    {
        static void Main(string[] args)
        {
            Agnostic_DataBase_Manager mng = new Agnostic_DataBase_Manager();
            List< Student > lst = mng.ExtractData();
            for( int i = 0; i < lst.Count; i++ )
            {
                String s = "ID = " + lst[i].ID;
                s += " - FirstName = " + lst[i].FirstName;
                s += " - Last Name = " + lst[i].LastName;
                Console.WriteLine(s);
            }
        }
    }
}
