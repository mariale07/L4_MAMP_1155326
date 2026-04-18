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
        Console.WriteLine("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        bool palindromo = true; //Se asumirá que es verdadero
        int longitud = palabra.Length; //cuenta las letras

        for (int i=0; i < longitud/2; i++) 
        {
            if (palabra[i] != palabra[longitud - 1 - i]) //Sirve para comparar la primera letra y recorrer desde atras para comparar la última
            {
                palindromo = false;
            }
        }

        if (palindromo == true)
        {
            Console.WriteLine("Es un palíndromo");
        } else
        {
            Console.WriteLine("No es un palíndromo");
        }

        //EJERCICIO 2
    }
}