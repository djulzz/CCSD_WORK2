using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Coach c1 = new Coach();
            Coach c2 = new Coach(c1);

            c2 = c1;

            // everything about arrays is going to
            // be dropped in the method below:
            PlaceHolderArrays.ExampleArrays();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Week02());

            PlaceHolderOverrideVirtual.Unit_Test();
            Console.ReadLine();
        }
    }
}
