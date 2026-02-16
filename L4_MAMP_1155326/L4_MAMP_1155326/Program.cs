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

        //EJERCICIO 3 - Casting explícito (pérdida de precisión)
        //Declaración de variables
        double precioExacto = 45.89;
        int precioRedondeado;
        precioRedondeado = (int)precioExacto;
        //Salida de datos
        Console.WriteLine("El precio exacto es: " + precioExacto + ", el precio redondeado es: " + precioRedondeado);
        Console.ReadLine();
        //Los decimales desaparece, no se aproxima el número.

        //EJERCICIO 4 - De un texto a un número (Parse)
        //Declaración de variables
        int numero;
        Console.WriteLine("Ingresar un número: ");
        //El error que marca es que un string no puede convertirse explícitamente en int, y como ReadLine siempre es un string, el número ingresado no será tomado como valor numérico.
        string entradaUsuario = Console.ReadLine();
        numero = int.Parse(entradaUsuario);
        int resultado = numero + 5;
        //Salida de datos
        Console.WriteLine("El resultado es: " + resultado);
        Console.ReadLine();

        //EJEERCICIO 5 - El uso de la clase "Convert"
        //Declaración de variables
        string valorTexto = "true";
        bool valorBooleano = Convert.ToBoolean(valorTexto);
        //Mi turno
        string valorDecimal = "25.5";
        double valorDouble = Convert.ToDouble(valorDecimal);
        //Salida de datos
        Console.WriteLine("El resultado del ejemplo es: " + valorBooleano);
        Console.ReadLine();
        Console.WriteLine("El resultado de mi ejercicio es: " + valorDecimal);
        Console.ReadLine();
    }
}
