using System;
using System.Collections.Generic;
using System.Text;

namespace external_library
{
    public class CheckingAccount : Account
    {
        public override void DoStuff()
        {

        }

        public CheckingAccount( Customer c, double initial_amount )
            : base( initial_amount, c )
        {
        }

        public CheckingAccount()
            : base()
        {
        }
    }
}
