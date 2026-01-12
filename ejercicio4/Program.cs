using System;
using System.Collections.Generic;

class Ejercicio4Precios
{
    static void Main()
    {
        Ejecutar();
    }DateTime

    public static void Ejecutar()
    {
        List<int> precios = new List<int>
        {
            50, 75, 46, 22, 80, 65, 8
        };

        precios.Sort();

        Console.WriteLine("Lista de precios:");
        foreach (var precio in precios)
        {
            Console.WriteLine(precio);
        }

        Console.WriteLine($"Precio menor: {precios[0]}");
        Console.WriteLine($"Precio mayor: {precios[precios.Count - 1]}");
        Console.WriteLine();
    }
}


