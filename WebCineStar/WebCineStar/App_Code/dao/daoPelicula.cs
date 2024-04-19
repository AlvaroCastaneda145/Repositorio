using System;

public class daoPelicula
{
    clsBD clsBD = new clsBD("cnCinestar");
    

    public daoPelicula() { }

    public object getPelicula(int idPelicula)
    {
        clsBD.Sentencia("sp_getPelicula " + idPelicula);
        return clsBD.getDataTable();
    }

    public object getPeliculas(int id)
    {
        if (id == 1 || id == 2)
        {
            clsBD.Sentencia("sp_getPeliculas " + id);
            return clsBD.getDataTable();
        }
        else
        {
           
            return null;
        }
    }
}