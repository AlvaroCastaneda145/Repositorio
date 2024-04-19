using System;

public partial class pages_Cine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id;
        string idCine = Request.QueryString["idCine"];
        if (idCine != null && int.TryParse(idCine, out id) ) {
            daoCine daoCine = new daoCine();
            fvCine.DataSource = daoCine.getCine(idCine);
            if (fvCine.DataSource == null)
                Response.Redirect("Inicio.aspx");

            ImgCine.ImageUrl = "../img/cine/" + idCine + ".2.jpg";
            ImgCine1.ImageUrl = "../img/cine/" + idCine + ".3.jpg";

            rptTarifas.DataSource = daoCine.getCineTarifas(idCine);
            rptPeliculas.DataSource = daoCine.GetCinePeliculas(idCine);
            DataBind();
        } 
    }
}