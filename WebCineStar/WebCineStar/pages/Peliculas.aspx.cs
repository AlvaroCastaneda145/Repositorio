using System;

public partial class pages_Peliculas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (int.TryParse(Request.QueryString["id"], out int idPelicula))
        {

            rptPeliculas.DataSource = new daoPelicula().getPeliculas(idPelicula);
            rptPeliculas.DataBind();


        }
        else
        {


            Response.Redirect("Inicio.aspx");
        }



    }

    
}