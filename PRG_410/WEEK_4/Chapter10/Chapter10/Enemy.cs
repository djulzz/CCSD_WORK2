using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    // Abstract methods can only fit into abstract classes.
    // Abstract methods do not have a body (no code associated with them)
    public abstract class Enemy
    {
        public abstract void Walk();
        public virtual void Talk()
        {
            Console.WriteLine("Grunt");
        }
    }


    public class BigBoss : Enemy
    {
        /// <summary>
        ///  This is redefining the method talk we had in the base class,
        ///  such that the child can behave differently (so BigBoss can emit a big
        ///  grunt instead of a regular grunt).. The requirements for that to take
        ///  place are:
        ///  - Talk needs to be virtual in the parent class\
        ///  - Talk needs to be overridden in the Derived class.
        /// </summary>
        public override void Talk()
        {
            Console.WriteLine("Big Grunt");
        }
    }
}
