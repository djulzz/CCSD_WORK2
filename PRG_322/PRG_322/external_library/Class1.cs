using System;

namespace external_library
{
    public class DLL
    {
        public static void DLL_Run( )
        {
            FirstName f = new FirstName( "Julien");
            LastName l = new LastName( "Esposito");
            SSN s = new SSN("111-11-1111");
            Customer c = new Customer( f, l, s);

            CheckingAccount ca = new CheckingAccount(c, 5000);
            SavingsAccount sa = new SavingsAccount(c, 20000);
            Console.WriteLine("ca = " + ca.GetRemainingBalance());
            Console.WriteLine("sa = " + sa.GetRemainingBalance());
        }
    }
}
