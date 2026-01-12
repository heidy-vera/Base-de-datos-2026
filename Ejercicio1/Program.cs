using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Ejercicio1Asignaturas.Ejecutar();
    }
}

class Ejercicio1Asignaturas
{
    public static void Ejecutar()
    {
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }

        Console.ReadKey(); 
    }
}