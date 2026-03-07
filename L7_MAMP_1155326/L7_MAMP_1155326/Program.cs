//Entrada de usuario
Console.WriteLine("¿Cómo te llamas?");
string nombre = Console.ReadLine();
//Salida de datos
Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");
Console.ReadLine();

Console.WriteLine("EJERCICIO 1 - WHILE");
Console.WriteLine("-------------------");
//Mostrar los números del 1 al 20.
string nom = "Maria Alejandra Montoya Pineda";
int carnet = 1155326;
int indice = 1;

Console.WriteLine("Nombre: " + nom + "Carnet: " + carnet.ToString());

while (indice <= 20)
{

    if (indice % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    Console.WriteLine(indice);
    indice = indice + 1;
}
Console.ForegroundColor = ConsoleColor.White;
Console.ReadLine();