using System;
using System.Collections.Generic;
class Ejercicio5Abecedario
{
    static void Main()
    {
        Ejecutar();
    }

    public static void Ejecutar()
    {
        List<char> abecedario = new List<char>();

        for (char c = 'a'; c <= 'z'; c++)
        {
            abecedario.Add(c);
        }

        for (int i = abecedario.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0)
            {
                abecedario.RemoveAt(i);
            }
        }

        Console.WriteLine("Abecedario resultante:");
        foreach (var letra in abecedario)
        {
            Console.Write(letra + " ");
        }
        Console.WriteLine();
    }
}

