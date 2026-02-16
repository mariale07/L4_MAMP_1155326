using System;
class Program {
    static void Main() {

        //EJERCICIO 1 - El perfil de un personaje
        //Declaración de variables
        string nombre = "Elena";
        int nivel = 15;
        float puntos_de_vida = 75.8F;
        bool es_un_jefe = false;
        //Salida de datos
        Console.WriteLine(nombre + " " + nivel + " " + puntos_de_vida + " " + es_un_jefe);
        Console.ReadLine();

        //EJERCICIO 2 - Conversión impícita (de pequeño a grande)
        //Declaración de variables
        int numeroEntero = 1500;
        long numeroLargo;
        numeroLargo = numeroEntero;
        //Salida de datos
        Console.WriteLine(numeroLargo);
        Console.ReadLine();
        //Declaro una nueva variable
        double numeroDecimal = numeroLargo;
        //Salida de datos
        Console.WriteLine("El número decimal es: " + numeroDecimal);
        Console.ReadLine();
    }
}
