
Console.WriteLine("Ingrese los datos del Personaje 1");
Personaje p1 = CrearPersonaje();

Console.WriteLine("Ingrese los datos del Personaje 2");
Personaje p2 = CrearPersonaje();
Console.Clear();
// Personaje[] personajes= new Personaje[] { p1, p2};
// MostrarPersonajes(personajes);
MostrarPersonajes([p1,p2]);
Console.WriteLine();
MostrarMenu();
ProcesarMenu();


Personaje CrearPersonaje()
{
    //Personaje pj = new Personaje();
    Personaje pj = new ();
    Console.WriteLine("Ingrese el color:");
    pj.Color = Console.ReadLine()!;
    Console.WriteLine("Ingrese el mana:");
    pj.Mana = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese la vida:");
    pj.Vida = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese la fuerza:");
    pj.Fuerza = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese la defensa:");
    pj.Defensa = int.Parse(Console.ReadLine()!);
    return pj;
}

void MostrarPersonajes(Personaje[] personajes)
{
    int i = 1;
    foreach(Personaje pj in personajes)
    {
        Console.WriteLine($"Datos del personaje {i++}");
        Console.WriteLine($"Color: {pj.Color}");
        Console.WriteLine($"Vida: {pj.Vida}");
        Console.WriteLine($"Mana: {pj.Mana}");
        Console.WriteLine($"Fuerza: {pj.Fuerza}");
        Console.WriteLine($"Defensa: {pj.Defensa}");
    }
}

void MostrarMenu()
{
    Console.WriteLine("Seleccione una opcion:");
    Console.WriteLine("1. Cambiar Color");
    Console.WriteLine("2. Recibir Daño");
    Console.WriteLine("3. Atacar");
}

void ProcesarMenu()
{
    while(true)
    {
        int opcion = int.Parse(Console.ReadLine()!);
        switch(opcion)
        {
            case 1:
                Console.WriteLine("Ingrese el nuevo color:");
                p1.CambiarColor(Console.ReadLine()!);
            break;
            case 2:
                Console.WriteLine("Ingrese el daño:");
                p1.RecibirDanio(int.Parse(Console.ReadLine()!));
            break;
            case 3:
                p1.Atacar(p2);
            break;
            default:
                Console.WriteLine("Opcion invalida");
            break;
        }
        Console.ReadKey();
        Console.Clear();
        MostrarPersonajes([p1,p2]);
        Console.WriteLine();
        MostrarMenu();
    }
}