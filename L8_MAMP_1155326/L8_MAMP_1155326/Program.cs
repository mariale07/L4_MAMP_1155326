// Entrada de usuario
Console.WriteLine("¿Cómo te llamas?");
string nombre = Console.ReadLine();
//Salida de datos
Console.WriteLine("Hola " + nombre + " ¡Bienvenido a C#!");
Console.ReadLine();
Console.WriteLine("--------------------------------");
Console.WriteLine("Ejercicio 1");
Console.WriteLine("--------------------------------");
int num;
int suma = 0;
Console.WriteLine("Ingrese un número: ");
num = int.Parse(Console.ReadLine());
int mayor = num;
int menor = num;
suma = num;
for (int i = 2; i <= 20; i++)
{
    Console.WriteLine("Ingrese otro número: ");
    num = int.Parse(Console.ReadLine());
    if (num > mayor)
    {
        mayor = num;
    }
    else if (num < menor)
    {
        menor = num;
    }
    suma = suma + num;
}
double promedio = suma / 20;
Console.WriteLine("El número mayor es: " + mayor);
Console.WriteLine("El número menor es: " + menor);
Console.WriteLine("El promedio es: " + promedio);
Console.ReadLine();

Console.WriteLine("--------------------------------");
Console.WriteLine("Ejercicio 2");
Console.WriteLine("--------------------------------");
for (int j=1; j<=100; j++)
{
    if(j % 2==0 && j % 7 == 0)
    {
        Console.WriteLine(j + " = ParSiete");
    }
    else if (j % 2 == 0)
    {
    Console.WriteLine(j + " = Par");
    } else if(j % 7 == 0){
    Console.WriteLine(j + " = Siete");
    }
    else
    {
    Console.WriteLine(j + " = No es múltiplo de 2 ni de 7.");
    }
}

Console.WriteLine("--------------------------------");
Console.WriteLine("Ejercicio 3");
Console.WriteLine("--------------------------------");