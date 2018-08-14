using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConnectionString
/// </summary>
public class ConnectionString
{
    private ConnectionString()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static String Value
    {
        get
        {
            return "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\djulzz\\Documents\\GitHub\\CCSD_WORK2\\PRG_410\\WEEK_3\\SkywardAviation\\App_Data\\SkywardAviation.mdf;Integrated Security = True";
        }
    }
}