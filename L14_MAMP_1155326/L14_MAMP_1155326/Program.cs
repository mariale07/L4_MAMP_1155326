using System;
using L14_MAMP_1155326;

class Program
{
    static void Main()
    {
        //EJERCICIO 1
        CuentaBancaria cuenta1 = new CuentaBancaria("Alejandra", "00125", 4000);
        CuentaBancaria cuenta2 = new CuentaBancaria("Luis", "00948", 5000);

        Console.WriteLine("Información inicial: ");
        cuenta1.mostrarInformacion();
        cuenta2.mostrarInformacion();
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Operaciones de cuenta 1");
        cuenta1.depositar(1000);
        cuenta1.retirar(3000);
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Operaciones de cuenta 2");
        cuenta2.depositar(500);
        cuenta2.retirar(1500);
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Información final:");
        cuenta1.mostrarInformacion();
        cuenta2.mostrarInformacion();
        Console.WriteLine("-------------------------------");
        Console.ReadKey();
    }
}