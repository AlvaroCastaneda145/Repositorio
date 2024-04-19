using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;


public class clsBD
{
    SqlConnection cn = null;
    SqlCommand cmd = null;
    SqlDataAdapter da = null;

    public clsBD() { }
    public clsBD(string BD)
    {
        //cn = new SqlConnection("Data Source=.;Initial Catalog=" + BD + ";Integrated Security=True");
        //cn = new  SqlConnection("Data Source=.;Initial Catalog=CineStar;Persist Security Info=True;User ID=alvaro;Password=123");
        cn = new SqlConnection( ConfigurationManager.ConnectionStrings[ BD ].ConnectionString );

        cmd = new SqlCommand( "", cn);
        da = new SqlDataAdapter(cmd);   
    }

    internal void Sentencia(string SQL)
    {
        cmd.CommandText = SQL;
    }

    internal object getDataTable()
    {
        DataTable dt = new DataTable();
        da.Fill(dt);    
        return ( dt.Rows.Count == 0 ? null : dt);
    }

   


}