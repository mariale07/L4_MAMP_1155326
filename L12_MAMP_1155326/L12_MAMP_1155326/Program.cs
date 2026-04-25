using System;
class Program
{
    static void Main()
    {
        // Entrada de usuario
            //EJERCICIO 1
        Console.WriteLine("----------Ejercicio 1----------");
        int[,] numeros = new int[5, 5];

        //Llamar procedimiento
        Llenar(numeros);

        //LLamar funciones
        int sumaPrincipal = diagonalPrincipal(numeros);
        int sumaSecundaria = diagonalSecundaria(numeros);

        Console.WriteLine("Suma de la diagonal principal: " + sumaPrincipal);
        Console.WriteLine("Suma de la diagonal secundaria: " + sumaSecundaria);
        
        // Salida de datos
       
    }

    //EJERCICIO 1

    static void Llenar(int[,] a)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j=0; j<5; j++)
            {
                Console.WriteLine("Ingrese un número: ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int diagonalPrincipal(int[,] a)
    {
        int suma = 0;
        {
            for(int i=0; i<5; i++)
            {
                suma = suma + a[i,i];
            }

            return suma;
        }
    }

    static int diagonalSecundaria(int[,] a)
    {
        int suma = 0;
        {
            for (int i = 0; i < 5; i++)
            {
                suma = suma + a[i, 4-i];
            }

            return suma;
        }
    }
}