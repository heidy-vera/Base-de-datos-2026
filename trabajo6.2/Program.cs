using System;

// Clase Nodo
class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

// Clase Lista Enlazada
class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    // Agregar nodo al final
    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Mostrar la lista
    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    // Eliminar nodos fuera del rango
    public void EliminarFueraDeRango(int min, int max)
    {
        // Eliminar desde la cabeza si está fuera de rango
        while (cabeza != null && (cabeza.Dato < min || cabeza.Dato > max))
        {
            cabeza = cabeza.Siguiente;
        }

        Nodo actual = cabeza;

        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Dato < min || actual.Siguiente.Dato > max)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            else
            {
                actual = actual.Siguiente;
            }
        }
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        Random random = new Random();

        // 1. Crear lista con 50 números aleatorios entre 1 y 999
        for (int i = 0; i < 50; i++)
        {
            lista.Agregar(random.Next(1, 1000));
        }

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // 2. Leer rango desde teclado
        Console.Write("\nIngrese el valor mínimo del rango: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(Console.ReadLine());

        // 3. Eliminar nodos fuera del rango
        lista.EliminarFueraDeRango(min, max);

        // 4. Mostrar lista final
        Console.WriteLine("\nLista después de eliminar valores fuera del rango:");
        lista.Mostrar();
    }
}

