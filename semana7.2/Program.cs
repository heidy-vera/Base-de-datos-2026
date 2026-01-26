using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static Stack<int> origen = new Stack<int>();
    static Stack<int> temporal = new Stack<int>();
    static Stack<int> destino = new Stack<int>();

    static void Main()
    {
        Console.WriteLine("Ingrese el número de discos:");
        string entrada = Console.ReadLine() ?? "";

        if (!int.TryParse(entrada, out int n) || n <= 0)
        {
            Console.WriteLine("Error: debe ingresar un número entero positivo.");
            return;
        }

        // Inicializar torre origen
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        Console.WriteLine("\nPasos para resolver las Torres de Hanoi:\n");
        ResolverHanoi(n, origen, destino, temporal, "Origen", "Destino", "Temporal");
    }

    static void ResolverHanoi(
        int n,
        Stack<int> origen,
        Stack<int> destino,
        Stack<int> temporal,
        string nombreOrigen,
        string nombreDestino,
        string nombreTemporal)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
        }
        else
        {
            ResolverHanoi(n - 1, origen, temporal, destino,
                          nombreOrigen, nombreTemporal, nombreDestino);

            MoverDisco(origen, destino, nombreOrigen, nombreDestino);

            ResolverHanoi(n - 1, temporal, destino, origen,
                          nombreTemporal, nombreDestino, nombreOrigen);
        }
    }

    static void MoverDisco(
        Stack<int> origen,
        Stack<int> destino,
        string nombreOrigen,
        string nombreDestino)
    {
        int disco = origen.Pop();
        destino.Push(disco);
        Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
    }
}



