using System;

class Nodo
{
    public int Valor;
    public Nodo Izquierdo;
    public Nodo Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

class ArbolBST
{
    public Nodo Raiz;

    public ArbolBST()
    {
        Raiz = null;
    }

    // Insertar
    public Nodo Insertar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = Insertar(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = Insertar(raiz.Derecho, valor);

        return raiz;
    }

    // Buscar
    public bool Buscar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return false;

        if (valor == raiz.Valor)
            return true;
        else if (valor < raiz.Valor)
            return Buscar(raiz.Izquierdo, valor);
        else
            return Buscar(raiz.Derecho, valor);
    }

    // Eliminar
    public Nodo Eliminar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return raiz;

        if (valor < raiz.Valor)
            raiz.Izquierdo = Eliminar(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = Eliminar(raiz.Derecho, valor);
        else
        {
            // Nodo sin hijo o con un hijo
            if (raiz.Izquierdo == null)
                return raiz.Derecho;
            else if (raiz.Derecho == null)
                return raiz.Izquierdo;

            // Nodo con dos hijos
            raiz.Valor = Minimo(raiz.Derecho);
            raiz.Derecho = Eliminar(raiz.Derecho, raiz.Valor);
        }

        return raiz;
    }

    // Recorridos
    public void Inorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Inorden(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            Inorden(raiz.Derecho);
        }
    }

    public void Preorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            Preorden(raiz.Izquierdo);
            Preorden(raiz.Derecho);
        }
    }

    public void Postorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Postorden(raiz.Izquierdo);
            Postorden(raiz.Derecho);
            Console.Write(raiz.Valor + " ");
        }
    }

    // Mínimo
    public int Minimo(Nodo raiz)
    {
        while (raiz.Izquierdo != null)
            raiz = raiz.Izquierdo;

        return raiz.Valor;
    }

    // Máximo
    public int Maximo(Nodo raiz)
    {
        while (raiz.Derecho != null)
            raiz = raiz.Derecho;

        return raiz.Valor;
    }

    // Altura
    public int Altura(Nodo raiz)
    {
        if (raiz == null)
            return -1;

        int izq = Altura(raiz.Izquierdo);
        int der = Altura(raiz.Derecho);

        return Math.Max(izq, der) + 1;
    }

    // Limpiar árbol
    public void Limpiar()
    {
        Raiz = null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENU ARBOL BINARIO DE BUSQUEDA ---");
            Console.WriteLine("1. Insertar valor");
            Console.WriteLine("2. Buscar valor");
            Console.WriteLine("3. Eliminar valor");
            Console.WriteLine("4. Recorrido Inorden");
            Console.WriteLine("5. Recorrido Preorden");
            Console.WriteLine("6. Recorrido Postorden");
            Console.WriteLine("7. Mostrar minimo");
            Console.WriteLine("8. Mostrar maximo");
            Console.WriteLine("9. Mostrar altura");
            Console.WriteLine("10. Limpiar arbol");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Insertar(arbol.Raiz, valor);
                    break;

                case 2:
                    Console.Write("Ingrese valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    if (arbol.Buscar(arbol.Raiz, valor))
                        Console.WriteLine("Valor encontrado");
                    else
                        Console.WriteLine("Valor no encontrado");
                    break;

                case 3:
                    Console.Write("Ingrese valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Eliminar(arbol.Raiz, valor);
                    Console.WriteLine("Valor eliminado");
                    break;

                case 4:
                    Console.WriteLine("Recorrido Inorden:");
                    arbol.Inorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    Console.WriteLine("Recorrido Preorden:");
                    arbol.Preorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine("Recorrido Postorden:");
                    arbol.Postorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine("Minimo: " + arbol.Minimo(arbol.Raiz));
                    break;

                case 8:
                    Console.WriteLine("Maximo: " + arbol.Maximo(arbol.Raiz));
                    break;

                case 9:
                    Console.WriteLine("Altura del arbol: " + arbol.Altura(arbol.Raiz));
                    break;

                case 10:
                    arbol.Limpiar();
                    Console.WriteLine("Arbol eliminado");
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        } while (opcion != 0);
    }
}
