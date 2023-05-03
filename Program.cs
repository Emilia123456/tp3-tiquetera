menu();



void menu(){
    Console.WriteLine("1. agregar | 2. | 3.buscarCliente | 4. cambiarEntrada | 5. Salir");
    int opcion = int.Parse(Console.ReadLine());
    while (opcion < 1 || opcion > 5){
        Console.WriteLine("Sos tontis, no sabes leer las opciones");
        opcion = int.Parse(Console.ReadLine());
    }
    switch (opcion){
        case 1:
            nuevaInscripcion();
            menu();
            break;
        case 2:
            break;
        case 3:
            buscarCliente();
            menu();
            break;
        case 4:
            cambiarEntradaACliente();
            menu();
            break;
        case 5:
            Console.WriteLine("Adios");
            Environment.Exit(-1);
            break;
    }
}

int ingresarEntero(string txt){
    int ent;
    Console.WriteLine(txt);
    ent=int.Parse(Console.ReadLine());
    return ent; 
}

string ingresarString(string txt){
    string str;
    Console.WriteLine(txt);
    str=Console.ReadLine();
    return str; 
}

void nuevaInscripcion(){
    string apellido, nombre;
    int dni, tAbonado=0, te;
    dni=ingresarEntero("Ingrese su DNI: ");
    apellido=ingresarString("Ingrese su apellido: ");
    nombre=ingresarString("Ingrese su nombre:");
    Console.WriteLine("Elija el tipo de entrada que quiera tener: 1= Día 1 - valor a abonar $15000, 2= Día 2 - valor a abonar $30000, 3= Día 3 - valor a abonar $10000, 4= full pass - valor a abonar $40000");
    te = ingresarEntero("Ingrese la opción:");
    while (te < 1 || te > 5){
        Console.WriteLine("Sos idiota, no sabes leer las opciones");
        te = int.Parse(Console.ReadLine());
    }
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
    }
    Cliente nuevoCliente = new Cliente(dni, apellido, nombre, DateTime.Today, te, tAbonado); 
    Tiquetera.AgregarCliente(nuevoCliente);
    // Se crea tu objeto
    // Pedis datos del cliente - DNI, apellido, nombre, tipo de entrada.
    // Creas el cliente
    // Llamas a tu clase y agregas al cliente al diccionario

}

void buscarCliente(){
    int idABuscar=ingresarEntero("Ingrese el id que quiera buscar:");
    Cliente cliente= Tiquetera.BuscarCliente(idABuscar);
    if(cliente != null){
        Console.WriteLine(cliente.DNI);
        Console.WriteLine(cliente.Nombre);
        Console.WriteLine(cliente.Apellido);
        Console.WriteLine(cliente.FechasInscripcion);
        Console.WriteLine(cliente.TipoEntrada);
        Console.WriteLine(cliente.TotalAbonado);
       
    }else{
        Console.WriteLine("El cliente ingresado no existe");
    }
    // Pido id para buscar
    // llamo a la funcion para buscar
    // muestro lo que me devolvio
}

void cambiarEntradaACliente(){
    int idAModificar, te, tAbonado=0;
    bool sePudo;
    idAModificar=ingresarEntero("Ingrese el id que desea modificar: ");
    te=ingresarEntero("Ingrese el nuevo tipo de entrada que desea");
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
    }
    sePudo=Tiquetera.cambiarEntrada(idAModificar, te, tAbonado);
    if (sePudo){
        Console.WriteLine("Se ha modificado con exito");
    } else{
        Console.WriteLine("No se pudo hacer el cambio");
    }

}
