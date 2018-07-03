using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            // This list will store primes
            List<int> primes = new List<int>();

            // List of counter to count
            // how many primes in each ranges:
            // - 0 - 10
            // - ...
            // - 90 - 100
            List<int> list2 = new List<int>();
            List<int> counters = new List<int>();
            for (int k = 0; k < 10; k++)
            {
                counters.Add(0);
                list2.Add(0);
            }
            for (; i < 100; i++ )
            {
                bool isPrime = true;
                for ( int j = 2; j < i; j++ )
                {
                    if( i % j == 0 )
                    {
                        isPrime = false;
                        
                        break;
                    }
                }

                if (isPrime == true)
                {
                    primes.Add(i);
                    if ((i > 0) && (i <= 10))
                        counters[0]++;
                    else if ((i >= 11) && (i <= 20))
                        counters[1]++;
                    else if ((i >= 21) && (i <= 30))
                        counters[2]++;
                    else if ((i >= 31) && (i <= 40))
                        counters[3]++;
                    else if ((i >= 41) && (i <= 50))
                        counters[4]++;
                    else if ((i >= 51) && (i <= 60))
                        counters[5]++;
                    else if ((i >= 61) && (i <= 70))
                        counters[6]++;
                    else if ((i >= 71) && (i <= 80))
                        counters[7]++;
                    else if ((i >= 81) && (i <= 90))
                        counters[8]++;
                    else if ((i >= 91) && (i <= 100))
                        counters[9]++;
                    //Console.WriteLine(i);
                }
            }

            for( int l = 0; l < counters.Count; l++ )
            {
                Console.WriteLine(counters[l]);
            }
        }
    }
}
