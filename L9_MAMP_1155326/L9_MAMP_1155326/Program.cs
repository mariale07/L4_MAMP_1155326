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

        //Ejercicio 2
        int a = 4;
        int b = 13;

        Console.WriteLine("----------EJERCICIO 2-----------");
        Console.WriteLine("Antes: ");
        Console.WriteLine("A= " + a);
        Console.WriteLine("B= " + b);

        intercambio(ref a, ref b);

        Console.WriteLine("Después: ");
        Console.WriteLine("A= " + a);
        Console.WriteLine("B= " + b);

    }
    //Ejercicio 1 - procedimiento
    static void caracter(string a)
    {
        Console.WriteLine(a.Length);
    }

    //Ejercicio 2 - procedimiento
    static void intercambio(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

}
