using System;

namespace AgendaTelefonica
{
    class Contacto
    {
         public string Nombre = "";
         public string Telefono = "";
         public string Correo = "";
    }

    // CLASE PRINCIPAL DE LA AGENDA
    class Agenda
    {
        Contacto[] contactos = new Contacto[50]; // Vector
        int contador = 0;

        public void Menu()

        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== AGENDA TELEFÓNICA ===");
                Console.WriteLine("1. Registrar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarContacto();
                        break;
                    case 2:
                        MostrarContactos();
                        break;
                    case 3:
                        BuscarContacto();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);
        }

        void RegistrarContacto()
        {
            if (contador < contactos.Length)
            {
                contactos[contador] = new Contacto();

                Console.Write("Nombre: ");
                contactos[contador].Nombre = Console.ReadLine();

                Console.Write("Teléfono: ");
                contactos[contador].Telefono = Console.ReadLine();

                Console.Write("Correo: ");
                contactos[contador].Correo = Console.ReadLine();

                contador++;
                Console.WriteLine("Contacto registrado correctamente.");
            }
            else
            {
                Console.WriteLine("Agenda llena.");
            }
        }

        void MostrarContactos()
        {
            Console.WriteLine("\n--- LISTA DE CONTACTOS ---");

            if (contador == 0)
            {
                Console.WriteLine("No existen contactos registrados.");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Contacto #{i + 1}");
                Console.WriteLine($"Nombre: {contactos[i].Nombre}");
                Console.WriteLine($"Teléfono: {contactos[i].Telefono}");
                Console.WriteLine($"Correo: {contactos[i].Correo}");
                Console.WriteLine("-------------------------");
            }
        }

        void BuscarContacto()
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombre = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < contador; i++)
            {
                if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nContacto encontrado:");
                    Console.WriteLine($"Nombre: {contactos[i].Nombre}");
                    Console.WriteLine($"Teléfono: {contactos[i].Telefono}");
                    Console.WriteLine($"Correo: {contactos[i].Correo}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }

    // MÉTODO MAIN
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            agenda.Menu();
        }
    }
}
