using System;

class Program
{
    static void Main()
    {
        Torneo torneo = new Torneo();

        while (true)
        {
            Console.WriteLine("\n1. Registrar equipo");
            Console.WriteLine("2. Listar equipos");
            Console.WriteLine("3. Simular partido");
            Console.WriteLine("4. Tabla");
            Console.WriteLine("5. Salir");

            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.Write("Nombre: ");
                string n = Console.ReadLine();
                torneo.RegistrarEquipo(n);
            }
            else if (op == 2)
            {
                torneo.ListarEquipos();
            }
            else if (op == 3)
            {
                Console.Write("Equipo 1: ");
                string a = Console.ReadLine();

                Console.Write("Equipo 2: ");
                string b = Console.ReadLine();

                torneo.SimularPartido(a, b);
            }
            else if (op == 4)
            {
                torneo.MostrarTabla();
            }
            else if (op == 5)
            {
                break;
            }
        }
    }
}