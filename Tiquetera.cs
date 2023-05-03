static class Tiquetera{
    private static Dictionary<int,Cliente> DicClientes = new Dictionary<int, Cliente>();
    private static int UltimoIDEntrada = 1;

    public static int DevolverUltimoID()
    {
        return UltimoIDEntrada;
    }

    public static int AgregarCliente(Cliente nuevoCliente)
    {
        int id = UltimoIDEntrada;
        DicClientes.Add(id, nuevoCliente); //suponemos que se ingreso toda la info de compra del cliente antes de pasarlo por parametro 
        UltimoIDEntrada++;
        return id;
    } 

    public static Cliente BuscarCliente(int idEntrada)
    {
        bool existe = DicClientes.ContainsKey(idEntrada); 
        if(existe){
            return DicClientes[idEntrada];
        }else{
            return null;
        }

    }
    public static bool cambiarEntrada(int idEntrada, int tipoEntrada, int importe)
    {
        if(TotalAbonado<=importe){
            DicClientes[idEntrada].TipoEntrada = tipoEntrada;
            DicClientes[idEntrada].TotalAbonado = importe;
            return true;
        }else{
            return false;
        }
    }

    public static List<string> estadisticasTiquetera(){
        List <string> estadisticas = new List <string>();
        string a = (UltimoIDEntrada+1).ToString(); //no me deja cambiarlo pucha,, mi lista es de strings no me acepta ezto
        estadisticas.Insert(0,a); // cant de personas instriptas
        return estadisticas; 
    }

}