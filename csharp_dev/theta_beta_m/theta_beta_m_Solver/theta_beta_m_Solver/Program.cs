using System;

namespace theta_beta_m_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //double angle = Math.PI;
            //double sin = Math.Sin(angle);
            //Console.WriteLine("The sine of 180 deg = " + sin);

            ThetaBetaMSolver solver1 = new ThetaBetaMSolver( 2.5, 20);

            MachNumber M = new MachNumber();
            M.M = 2.5;
            AngleDeg angle = new AngleDeg();
            angle.angle = 20;

            double angleDeg = 20;
            double angleRad = ThetaBetaMSolver.DegToRad(angleDeg );
            ThetaBetaMSolver solver = new ThetaBetaMSolver(M, angle);

            Console.WriteLine( "The abs value of -1 is = " + Math.Abs(-1.0) );
            Console.Read();
        }
    }
}
