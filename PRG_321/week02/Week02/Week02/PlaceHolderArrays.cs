using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
namespace Week02
{
    public class PlaceHolderArrays
    {
        public static void ExampleArrays()
        {
            int[] a1, a2;
            a1 = new int[5] { 1, 2, 3, 4, 5 };
            a2 = new int[5] { 1, 2, 3, 4, 5 };


            ArrayList res = new ArrayList();
            for (int i = 0; i < a1.Length; i++)




                res.Add(a1[i] * a2[i]);

            for (int i = 0; i < res.Count; i++)

                Console.WriteLine("res[ " + i + " ] = " + res[i]);



        }
    }
}
