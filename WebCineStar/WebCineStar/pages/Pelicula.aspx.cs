using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Pelicula : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        if (int.TryParse(Request.QueryString["idPelicula"], out int idPelicula))
        {
            rptPelicula.DataSource = new daoPelicula().getPelicula(idPelicula);
            rptPelicula.DataBind();
        }




    }
}