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
        if(DicClientes[idEntrada].TotalAbonado<=importe){
            DicClientes[idEntrada].TipoEntrada = tipoEntrada;
            DicClientes[idEntrada].TotalAbonado = importe;
            return true;
        }else{
            return false;
        }
    }

    public static List<string> estadisticasTiquetera(){
        List <string> estadisticas = new List <string>();
        int tipo1 = 0, tipo2 = 0, tipo3 = 0, tipo4 = 0;

        int cantClientes = DicClientes.Count();

        for (int i = 1; i<=cantClientes; i++){
            switch (DicClientes[i].TipoEntrada){
                case 1:
                    tipo1++;
                    break;
                case 2:
                    tipo2++;
                    break;
                case 3:
                    tipo3++;
                    break;
                case 4:
                    tipo4++;
                    break;
            }
        }

        estadisticas.Add("Cantidad de clientes: " + cantClientes);
        estadisticas.Add("Porcentaje de entradas:");
        estadisticas.Add("  Tipo 1: " + (tipo1 / cantClientes * 100));
        estadisticas.Add("  Tipo 2: " + (tipo2 / cantClientes * 100));
        estadisticas.Add("  Tipo 3: " + (tipo3 / cantClientes * 100));
        estadisticas.Add("  Tipo 4: " + (tipo4 / cantClientes * 100));
        estadisticas.Add("Recaudacion por entrada:");
        estadisticas.Add("  Tipo 1: " + (tipo1 * 15000)+ "%");
        estadisticas.Add("  Tipo 2: " + (tipo2 * 30000)+ "%");
        estadisticas.Add("  Tipo 3: " + (tipo3 * 10000)+ "%");
        estadisticas.Add("  Tipo 4: " + (tipo4 * 40000)+ "%");
        estadisticas.Add("Recaudacion Total: " + (tipo1 * 15000 + tipo2 * 30000 + tipo3 * 10000 + tipo4 * 40000));
        
        return estadisticas; 
    }


}