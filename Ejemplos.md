
dotnet run -- --help 

[argumentos para dotnet ] -- [ argumentos que se le pasan al programa]

## si escribo : 
dotnet run -- --hola mundo 
args[0] = "hola"
args[1] = "mundo"

## si ejecutase por ej 
dotnet run -- --Agregar laptos 500 -> CUANTOS ARGUMENTOS TENDRE?
R= tendria 3 argumentos
args[0] = "Agregar"
args[1] = "laptos"
args[2] = "500"

## signoficado de codigos Exit code en el  switch 
Exit(0) -> exito, todo bien
Exit(1) -> error general, algo fallo 
Exit(2) -> uso incorrecto , argumentos invalidos 

estos codigos validan los conmandos antes de continuar


//------------------------
//null, vacio, vs cero 

//problema: un ReadLine puede devolver null 

Console.WriteLine("Ingresa un valor: ");
string? lectura = Console.ReadLine();
int? longitud = lectura?.Length;


// solucion : la nulabilidad segura con el operador coalesing  -> ??
El operador de coalescencia nula en C# (??) devuelve el valor del operando izquierdo si no es nulo; 
de lo contrario, evalúa y devuelve el operando derecho. Simplifica la asignación de valores predeterminados 
y evita comprobaciones de if extensas para tipos anulables o de referencia. 


//string comando = string.IsNullOrEmpty(lectura) ? "salida" : lectura;
//Console.WriteLine($"Comando recibido: {comando}");

// otro ejemplo
string comandoLimpio = string.IsNullOrEmpty(lectura) ? "salida" : lectura.Trim().ToLower();

Console.WriteLine($"Longitud: {longitud}");
Console.WriteLine($"ComandoLimpio: {comandoLimpio}");

//--------------------------