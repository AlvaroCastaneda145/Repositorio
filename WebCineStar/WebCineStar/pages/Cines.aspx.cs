using System;

public partial class pages_Cines : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        rptCines.DataSource = new daoCine().getCines();
            rptCines.DataBind();

            if (rptCines.DataSource == null)
                Response.Redirect("Inicio.aspx");
        
    }

}