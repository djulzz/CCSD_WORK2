using System;

namespace theta_beta_m_Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ThetaBetaMSolver solver1 = new ThetaBetaMSolver( 2.5, 20);

            MachNumber M = new MachNumber();
            M.M = 2.5;
            AngleDeg angle = new AngleDeg();
            angle.angle = 20;

            double angleDeg = 20;
            double angleRad = ThetaBetaMSolver.DegToRad(angleDeg );
            ThetaBetaMSolver solver = new ThetaBetaMSolver(M, angle);
            double beta = solver.FindBeta();
            Console.WriteLine("Beta = " + beta + " deg");
            Console.Read();
        }
    }
}
