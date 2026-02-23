using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Crear 500 pacientes ficticios 
        HashSet<string> pacientes = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            pacientes.Add("Paciente " + i);
        }

        // 2. Crear conjuntos

        HashSet<string> vacunadosPfizer = new HashSet<string>();
        HashSet<string> vacunadosAstraZeneca = new HashSet<string>();

        // Pfizer: Pacientes 1 al 75
        for (int i = 1; i <= 75; i++)
        {
            vacunadosPfizer.Add("Paciente " + i);
        }

        // AstraZeneca: Pacientes 51 al 125
        for (int i = 51; i <= 125; i++)
        {
            vacunadosAstraZeneca.Add("Paciente " + i);
        }

        // Operaciones 

        // A. Pacientes que NO se han vacunado:
        var vacunadosCualquiera = new HashSet<string>(vacunadosPfizer);
        vacunadosCualquiera.UnionWith(vacunadosAstraZeneca);

        var noVacunados = new HashSet<string>(pacientes);
        noVacunados.ExceptWith(vacunadosCualquiera);

        // B. Pacientes con AMBAS dosis: 
        var ambasDosis = new HashSet<string>(vacunadosPfizer);
        ambasDosis.IntersectWith(vacunadosAstraZeneca); 

        // C. Solo Pfizer: 
        var soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca); 

        // D. Solo AstraZeneca:
        var soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // --- MOSTRAR RESULTADOS ---
        
        MostrarResultados("PACIENTES NO VACUNADOS", noVacunados);
        MostrarResultados("PACIENTES CON AMBAS DOSIS", ambasDosis);
        MostrarResultados("SOLO VACUNA PFIZER", soloPfizer);
        MostrarResultados("SOLO VACUNA ASTRAZENECA", soloAstraZeneca);

        // Resumen Final
        Console.WriteLine("\n RESUMEN ESTADÍSTICO ");
        Console.WriteLine($"Total Pacientes: {pacientes.Count}");
        Console.WriteLine($"No vacunados: {noVacunados.Count}");
        Console.WriteLine($"Ambas dosis: {ambasDosis.Count}");
        Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Solo AstraZeneca: {soloAstraZeneca.Count}");
    }

    static void MostrarResultados(string titulo, HashSet<string> conjunto)
    {
        Console.WriteLine($"\n {titulo} (Total: {conjunto.Count}) ");
        
        int count = 0;
        foreach (var p in conjunto)
        {
            if (count < 5)
                Console.WriteLine($"- {p}");
            count++;
        }

        if (conjunto.Count > 5)
            Console.WriteLine("  ... entre otros.");
    }
}