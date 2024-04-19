using System;

public class daoCine
{
    clsBD clsBD = new clsBD("Cinestar");

    public object getCines()
    {
        clsBD.Sentencia("sp_getCines");
        return clsBD.getDataTable();

    }

    public object getCine(string id)
    {
        clsBD.Sentencia("sp_getCine " + id );
        return clsBD.getDataTable();
    }

    public object GetCinePeliculas(string id)
    {
        clsBD.Sentencia("sp_getCinePeliculas " + id );
        return clsBD.getDataTable();
    }

    public object getCineTarifas(string id)
    {
        clsBD.Sentencia("sp_getCineTarifas " + id );
        return clsBD.getDataTable();
    }


}