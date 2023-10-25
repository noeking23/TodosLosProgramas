using System;

public class Comparacion
{
    public static void DeterminarElMayor()
    {
        Console.WriteLine("Ingrese el primer número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine($"El número mayor es: {numero1}");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"El número mayor es: {numero2}");
        }
        else
        {
            Console.WriteLine("Ambos números son iguales.");
        }
    }
}
