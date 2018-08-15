using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    public class Enemy
    {
        public virtual void Talk()
        {
            Console.WriteLine("Grunt");
        }
    }


    public class BigBoss : Enemy
    {
        public override void Talk()
        {
            Console.WriteLine("Big Grunt");
        }
    }
}
