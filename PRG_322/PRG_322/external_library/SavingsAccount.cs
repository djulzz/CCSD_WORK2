using System;
using System.Collections.Generic;
using System.Text;

namespace external_library
{
    public class SavingsAccount : Account
    {
        // implement DoStuff
        // make sure the class' constructor is calling the 
        // parent class' constructor (AKA base()  )
        public override void DoStuff()
        {
        }

        public SavingsAccount( Customer c, double initial_amount )
        : base(initial_amount, c )
        {
        }

        public SavingsAccount() : base()
        {
            //mCustomer = new Customer();
        }
    }
}
