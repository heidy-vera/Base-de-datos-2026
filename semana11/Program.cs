using System;
using System.Collections.Generic;

class Traductor
{
    static void Main()
    {
        // Diccionario Español → Inglés
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"tiempo", "time"},
            {"persona", "person"},
            {"año", "year"},
            {"día", "day"},
            {"cosa", "thing"},
            {"hombre", "man"},
            {"mundo", "world"},
            {"vida", "life"},
            {"mano", "hand"},
            {"ojo", "eye"},
            {"mujer", "woman"},
            {"lugar", "place"},
            {"trabajo", "work"},
            {"semana", "week"},
            {"gobierno", "government"}
        };

        int opcion;

        do
        {
            Console.WriteLine("==== MENÚ ====");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la frase: ");
                    string frase = Console.ReadLine();
                    string[] palabras = frase.Split(' ');
                    string traduccion = "";

                    foreach (string palabra in palabras)
                    {
                        string limpia = palabra.ToLower().Replace(".", "").Replace(",", "");

                        if (diccionario.ContainsKey(limpia))
                        {
                            traduccion += diccionario[limpia] + " ";
                        }
                        else
                        {
                            traduccion += palabra + " ";
                        }
                    }

                    Console.WriteLine("Traducción: " + traduccion);
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Ingrese la palabra en español: ");
                    string esp = Console.ReadLine().ToLower();

                    Console.Write("Ingrese la traducción en inglés: ");
                    string ing = Console.ReadLine().ToLower();

                    if (!diccionario.ContainsKey(esp))
                    {
                        diccionario.Add(esp, ing);
                        Console.WriteLine("Palabra agregada correctamente.\n");
                    }
                    else
                    {
                        Console.WriteLine("La palabra ya existe en el diccionario.\n");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.\n");
                    break;
            }

        } while (opcion != 0);
    }
}
