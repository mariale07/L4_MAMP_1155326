using System;
class Program
{
    static void Main()
    {
        // Entrada de usuario
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        // Salida de datos

        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        //Ejercicio 1
        Console.WriteLine("----------EJERCICIO 1-----------");
        caracter("Raton");
        caracter("Insomnio");
    }
    //Ejercicio 1 - procedimiento
    static void caracter(string a)
    {
        Console.WriteLine(a.Length);
    }
}
