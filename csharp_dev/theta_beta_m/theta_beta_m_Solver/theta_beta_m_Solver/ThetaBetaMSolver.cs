using System;
using System.Collections.Generic;
using System.Text;

namespace theta_beta_m_Solver
{
    public class ThetaBetaMSolver
    {
        private double m_M;
        private double m_Theta_Deg;
        private double m_Beta_Deg;

        private const double gamma = 1.4;

        public static double DegToRad( double angleDegree )
        {
            return angleDegree * Math.PI / 180.0;
        }

        public static double RadToDeg( double angleRad )
        {
            return angleRad * 180.0 / Math.PI;
        }
        private ThetaBetaMSolver()
        { }

        public ThetaBetaMSolver( double M, double Theta_Deg )
        {

        }

        public ThetaBetaMSolver( MachNumber M, AngleDeg angle )
        {
            m_M = M.M;
            m_Theta_Deg = angle.angle;
            m_Beta_Deg = m_Theta_Deg;
        }

        public double FindBeta( )
        {
            bool solutionFound = false;
            double tolerance = 0.01;
            double beta_step = 0.01;
            while( solutionFound == false )
            {
                double LHS = UpdateLHS();
                double RHS = UpdateRHS();
                double error = Math.Abs(LHS - RHS);
                if( error <= tolerance )
                {
                    solutionFound = true;
                } else
                {
                    m_Beta_Deg = m_Beta_Deg + beta_step;
                }
            }
            return m_Beta_Deg;
        }

        public double UpdateLHS()
        {
            double theta_rad = ThetaBetaMSolver.DegToRad(m_Theta_Deg);
            double beta_rad = ThetaBetaMSolver.DegToRad(m_Beta_Deg);

            double t3 = Math.Tan(theta_rad) * Math.Tan(beta_rad);
            double t2 = m_M * m_M;
            double t1 = gamma + Math.Cos(2.0 * beta_rad);
            return t3 * (t2 * t1 + 2);
        }

        public double UpdateRHS()
        {
            double t1 = m_M * m_M;
            double beta_rad = ThetaBetaMSolver.DegToRad(m_Beta_Deg);
            double t2 = Math.Sin(beta_rad) * Math.Sin(beta_rad);
            return 2.0 * (t1 * t2 - 1);
        }
    }
}
