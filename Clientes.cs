class Cliente{
    public int DNI{get; private set;}
    public string Apellido{get; private set;}
    public string Nombre{get; private set;}
    public DateTime FechasInscripcion{get; set;}
    public int TipoEntrada{get; set;}
    public int TotalAbonado{get; set;}


public Cliente(){
    DNI=0;
    Apellido="";
    Nombre="";
    FechasInscripcion=DateTime.Today;
    TipoEntrada=0;
    TotalAbonado=0;

}
public Cliente(int dni, string apellido, string nombre, DateTime fi, int te, int ta){
    DNI=dni;
    Apellido=apellido;
    Nombre=nombre;
    FechasInscripcion=fi;
    TipoEntrada=te;
    TotalAbonado=ta;
}
}


/*
        switch(te){
        case 1:
            tAbonado=15000;
            break;
        case 2:
            tAbonado=30000;
            break;
        case 3:
            tAbonado=10000;
            break;
        case 4:
            tAbonado=40000;
            break;
        }*/