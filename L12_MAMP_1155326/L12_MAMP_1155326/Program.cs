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


        //EJERCICIO 3
        Console.WriteLine();
        Console.WriteLine("----------Ejercicio 3----------");
        Console.WriteLine();
        float[,] notas = new float[5, 4];

        llenarNotas(notas);

        for (int i=0; i<5; i++)
        {
            float promedio = promedioEstudiante(notas, i);
            bool estado = estadoEstudiante(promedio);

            if (estado == true)
            {
                Console.WriteLine();
                Console.WriteLine("El estudiante aprobó." + (i+1));
            }
            else if (estado == false)
            {
                Console.WriteLine("El estudiante reprobó");
            }
            Console.WriteLine("El promedio del estudiante es: " + promedio);
        }

        
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


    //EJERCICIO 2
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


    //EJERCICIO 3
    static void llenarNotas(float[,] c)
    {
        for (int i=0; i<5; i++)
        {
            Console.WriteLine("Estudiante " + (i + 1));
            for (int j = 0; j<4; j++)
            {
                Console.WriteLine("Ingrese la nota del estudiante " + (j + 1) + " : ");
                c[i, j] = float.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }

    static float promedioEstudiante(float [,] c, int estudiante)
    {
        float suma = 0;
            for(int j=0; j < 4; j++)
            {
                suma = suma + c[estudiante, j];
            }
        return suma / 4;
    }

    static bool estadoEstudiante(float promedio)
    {
        if (promedio >= 61)
        {
            return true;
        } else
        {
            return false;
        }
    }
}