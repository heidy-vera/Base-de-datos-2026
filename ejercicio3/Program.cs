using System;
class Ejercicio3Vocales
{
    static void Main()
    {
        Ejecutar();
    }

    public static void Ejecutar()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        int a = 0, e = 0, i = 0, o = 0, u = 0;

        foreach (char letra in palabra)
        {
            switch (letra)
            {
                case 'a': a++; break;
                case 'e': e++; break;
                case 'i': i++; break;
                case 'o': o++; break;
                case 'u': u++; break;
            }
        }

        Console.WriteLine("Cantidad de vocales:");
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"e: {e}");
        Console.WriteLine($"i: {i}");
        Console.WriteLine($"o: {o}");
        Console.WriteLine($"u: {u}");
        Console.WriteLine();
    }
}

