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

        //EJERCICIO 1
        Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = sumardigitos(numero);

        Console.WriteLine("La suma de los dígitos es: " + resultado);
    }
    //Función
    static int sumardigitos(int numero)
    { 
    int suma = 0;

        while (numero > 0)
        {
            suma = suma + (numero %10);
            numero = numero / 10;
        }
return suma;
    }

}