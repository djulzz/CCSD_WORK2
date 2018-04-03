using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Car
/// </summary>
public class Car
{
    public int      m_ID;
    public String   m_Make;
    public String   m_Model;
    public double   m_Price;
    public int      m_mpgc;
    public int      m_mpgh;

    public Car( int ID, String Make, String Model, double Price, int mpgc, int mpgh )
    {
        m_ID = ID;
        m_Make = Make;
        m_Model = Model;
        m_Price = Price;
        m_mpgc = mpgc;
        m_mpgh = mpgh;
    }
}