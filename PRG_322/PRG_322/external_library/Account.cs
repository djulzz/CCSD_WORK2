using System;
using System.Collections.Generic;
using System.Text;

namespace external_library
{
     public abstract class Account : Object
    {
        public double mBalance;
        protected Customer mCustomer;

       abstract public void DoStuff();
        protected Account( double balance, Customer c )
        {
            mBalance = balance;
            mCustomer = c;
        }
        public void Deposit(double amount2Deposit)
        {
            mBalance = mBalance + amount2Deposit;
        }
        public void Withdraw(double amount2Withdraw)
        {
            mBalance = mBalance - amount2Withdraw;
            if( mBalance < 0 )
            {
                BalanceOverdrawnException e = new BalanceOverdrawnException("The account got overdrawn");
                throw e;
            }
        }
        public double GetRemainingBalance()
        {
            return mBalance;
        }
        public double Balance
        {
            set
            {
                mBalance = value;
            }

            get
            {
                return mBalance;
            }
        }
        protected  Account()
        {
            mBalance = 0.0;
            //mCustomer = new Customer();
        }
    }
}
