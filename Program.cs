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

Console.WriteLine("!----------------------------------!");
Console.WriteLine("! SISTEMA DE GESTION DE INVENTARIO !");
Console.WriteLine("!----------------------------------!");
Console.WriteLine();
Console.WriteLine("Version: 1.0.0");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine("");
Console.WriteLine("Estado: Proyecto Inicializado");
Console.WriteLine("");
Console.WriteLine($"Verificacion de Version: {version}");
