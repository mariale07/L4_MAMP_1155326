using System;
class Program
{
    static void Main()
    {
            //EJERCICIO 1
        Console.WriteLine("----------Ejercicio 1----------");
        Console.WriteLine();
        int[,] numeros = new int[5, 5];

        //Llamar procedimiento
        Llenar(numeros);

        //LLamar funciones
        int sumaPrincipal = diagonalPrincipal(numeros);
        int sumaSecundaria = diagonalSecundaria(numeros);

        Console.WriteLine("Suma de la diagonal principal: " + sumaPrincipal);
        Console.WriteLine("Suma de la diagonal secundaria: " + sumaSecundaria);

        //EJERCICIO 2
        Console.WriteLine();
        Console.WriteLine("----------Ejercicio 2----------");
        Console.WriteLine();
        int[,] enteros = new int[4, 6];

        llenar(enteros);

        int pares = numerosPares(enteros);
        int impares = numerosImpares(enteros);

        Console.WriteLine("Hay " + pares + " numeros pares.");
        Console.WriteLine("Hay " + impares + " numeros impares.");

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


    //Ejercicio 2
    static void llenar(int[,] b)
    {
        for (int i=0; i<4; i++)
        {
            for (int j=0; j<6; j++)
            {
                Console.WriteLine("Ingrese un número: ");
                b[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int numerosPares(int[,] b)
    {
        int contador = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (b[i, j] % 2 == 0)
                    {
                        contador = contador + 1;
                    }
                }
            }
        return contador;
    }

    static int numerosImpares(int[,] b)
    {
        int contador = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (b[i, j] % 2 != 0)
                {
                    contador = contador + 1;
                }
            }
        }
        return contador;
    }
}