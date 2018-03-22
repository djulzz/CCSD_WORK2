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
            return 0.0;
        }
    }
}
