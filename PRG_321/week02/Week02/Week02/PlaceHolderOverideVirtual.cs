using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    public class Parent
    {
        virtual public void SayHello()
        {
            Console.WriteLine("Parent");
        }
    }

    public class Child : Parent
    {
        override public void SayHello()
        {
            Console.WriteLine("Child");
        }
    }

    public class PlaceHolderOverrideVirtual
    {
        public static void Unit_Test()
        {
            Parent p = new Parent();
            Child c = new Child();

            p.SayHello();
            c.SayHello();
            return;
        }
    }
}
