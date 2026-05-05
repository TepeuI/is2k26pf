using System.Data.Odbc;

public class CNX
{
    private static string cadena = "DSN=bd_SIG;Uid=root;Pwd=Acces0F3R;";

    public static OdbcConnection ObtenerConexion()
    {
        return new OdbcConnection(cadena);
    }
}