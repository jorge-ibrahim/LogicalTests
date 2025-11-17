// See https://aka.ms/new-console-template for more information


var numberStrin = string.Empty;//lo declaro como strin vacio tambien podria poner "".
var numberInt = 0; //con el ! saco la linea de advertencia



do
{
    Console.WriteLine("Ingrese un numero para ver si es par, o presione salir para salir");
    numberStrin = Console.ReadLine();
    if(numberStrin!.ToLower() == "salir" )//el tolower convierte todo a minuscula para evitar errores 
    {
        continue;//este continue lo que haces es que si la condicion es correcta pasa directamente
                 //a la condicion del do while
    }
    if (int.TryParse(numberStrin, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El Numero {numberInt}, es par.");
        }
        else
        {
            Console.WriteLine($"El Numero {numberInt}, es impar.");
        }

    }
    else
    {
        Console.WriteLine($"Lo que ingresaste {numberStrin} no es un valor valido.");
    }
}
while (numberStrin.ToLower() != "salir");

