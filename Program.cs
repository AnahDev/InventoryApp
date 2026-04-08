// SISTEMA DE INVENTRIO ,
//------------------------------------------------------------------------------------
//Metadata que va en .csproj
//Nombre para el ejecutable del programa 
//< AssemblyName > InventarioApp </ AssemblyName >
////Nombre de Namespace , carpeta de archivos
//< RootNamespace > InventarioApp </ RootNamespace >
//< Version > 1.0.0 </ Version >
//< Descripcion > Sistema de Gestiond de Inventario - Curso .Net</Descripcion>
//-------------------------------------------------------------------------------------

using System.Reflection;
//para poder leer dstos del archivo de .csproj
var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

//manejo de argumentos

if (args.Length > 0)
{
    switch (args[0].ToLower())
    {
        case "--help":
            MostrarAyuda();
            Environment.Exit(0);
            break;

        case "--version":
            Console.WriteLine($"InventarioApp v[{version}]");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine($"Error: Comando desconocido '{args[0]}'");
            Console.WriteLine($"use --help para ver los comandos disponibles");
            Environment.Exit(2);
            break;


    }
}

MostrarBanner();

//Modo interactivo si no hay argumentos 
Console.Write("Ingresa un comando ( o 'salir' para terminar): ");
    string? entrada = Console.ReadLine();

    if(string.IsNullOrWhiteSpace( entrada ) || entrada.ToLower() == "salir")
{
    Console.WriteLine("Hasta luego!");
    Environment.Exit(0);
} 


/*
Console.WriteLine("Metadatos configurados (.csproj)");
Console.WriteLine("Estado: Proyecto Inicializado");
Console.WriteLine("");
Console.WriteLine($"Verificacion de Version: {version}");
Console.WriteLine("");
Console.WriteLine("Estructura de Proyecto:");
Console.WriteLine(" InventarioApp/");
Console.WriteLine("     |-- Program.cs");
Console.WriteLine("     |-- InveantarioApp.csproj");
Console.WriteLine("     |-- .gitignore");
Console.WriteLine("     |-- README.md");
Console.WriteLine("     |-- src/");
Console.WriteLine("         |--Models");
Console.WriteLine("             |--.gitkeep");
Console.WriteLine("");
Console.WriteLine("");
*/


//######### FUNCIONES ############

void MostrarBanner()
{
    Console.WriteLine("!----------------------------------!");
    Console.WriteLine("! SISTEMA DE GESTION DE INVENTARIO !");
    Console.WriteLine("!----------------------------------!");
    Console.WriteLine();
    Console.WriteLine("Version: 1.0.0");
    Console.WriteLine($"Plataforma: {Environment.OSVersion}");
    Console.WriteLine($".NET Version: {Environment.Version}");
    Console.WriteLine("");

}

void MostrarAyuda()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h      Muestra esta ayuda");
    Console.WriteLine("  --version, -v   Muestra la version del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine(" dotnet run -- --help");
    Console.WriteLine(" dotnet run -- --version");
}