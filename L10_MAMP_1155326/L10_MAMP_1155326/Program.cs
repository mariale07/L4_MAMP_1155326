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

        //EJERCICIO 2
        Console.WriteLine("Ingrese su primer nombre: ");
        String nombre1 = Console.ReadLine();
        Console.WriteLine("Ingrse su segundo nombre: ");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("Ingrese su apellido paterno: ");
        string apellido1 = Console.ReadLine();
        Console.WriteLine("Ingrese su apellido materno: ");
        string apellido2 = Console.ReadLine();

        string correo = generar_correo(nombre1, nombre2, apellido1, apellido2);

        Console.WriteLine("Correo institucional: " + correo);

        //EJERCICIO 3
        Console.WriteLine("Ingrese una temperatura en Celsius: ");
        string celsius = Console.ReadLine();

        double fahrenheit = 0;
        string respuesta = temperatura(celsius, ref fahrenheit);

        Console.WriteLine(respuesta);
    }

    //Función - ejercicio 1
    static int sumardigitos(int numero)
    {
        int suma = 0;

        while (numero > 0)
        {
            suma = suma + (numero % 10);
            numero = numero / 10;
        }
        return suma;
    }

    //Función - ejercicio 2
    static string generar_correo(string nombre1, string nombre2, string apellido1, string apellido2)
    {
    string correo = "";
    correo = nombre1.Substring(0,1) + nombre2.Substring(0,1) + apellido1 + apellido2.Substring(0,1) + "@correo.url.edu.gt";

        return correo.ToLower();
    }

    //Integración - ejercicio 3
    static string temperatura(string celsius, ref double fahrenheit)
    {
        string num = celsius.Replace("C = ", "");
        double tempC = double.Parse(num);
        fahrenheit = (tempC * 9 / 5) + 32;

        return celsius + "°C -->" + "°F = " + fahrenheit;
    }
}