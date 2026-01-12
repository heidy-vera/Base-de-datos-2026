using System;
using System.Collections.Generic;

class Ejercicio2NumerosInversos
{
    static void Main()
    {
        Ejecutar();
    }

    public static void Ejecutar()
    {
        List<int> numeros = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        numeros.Reverse();

        Console.WriteLine("Números en orden inverso:");
        Console.WriteLine(string.Join(", ", numeros));
        Console.WriteLine();
    }
}

