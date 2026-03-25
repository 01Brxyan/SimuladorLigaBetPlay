using System;
using System.Collections.Generic;
using System.Linq;

public class Torneo
{
    public List<Equipo> Equipos = new List<Equipo>();

    public void RegistrarEquipo(string nombre)
    {
        Equipos.Add(new Equipo(nombre));
    }

    public void ListarEquipos()
    {
        foreach (var e in Equipos)
        {
            Console.WriteLine(e.Nombre);
        }
    }

    public void SimularPartido(string a, string b)
    {
        var eq1 = Equipos.FirstOrDefault(e => e.Nombre == a);
        var eq2 = Equipos.FirstOrDefault(e => e.Nombre == b);

        if (eq1 == null || eq2 == null)
        {
            Console.WriteLine("Error equipos");
            return;
        }

        Random r = new Random();

        int g1 = r.Next(0, 5);
        int g2 = r.Next(0, 5);

        Console.WriteLine($"{eq1.Nombre} {g1} - {g2} {eq2.Nombre}");

        eq1.PJ++;
        eq2.PJ++;

        eq1.GF += g1;
        eq1.GC += g2;

        eq2.GF += g2;
        eq2.GC += g1;

        if (g1 > g2)
        {
            eq1.PG++;
            eq1.TP += 3;
            eq2.PP++;
        }
        else if (g2 > g1)
        {
            eq2.PG++;
            eq2.TP += 3;
            eq1.PP++;
        }
        else
        {
            eq1.PE++;
            eq2.PE++;
            eq1.TP++;
            eq2.TP++;
        }
    }

    public void MostrarTabla()
    {
        var tabla = Equipos
            .OrderByDescending(e => e.TP)
            .ThenByDescending(e => e.DiferenciaGoles())
            .ThenByDescending(e => e.GF)
            .ThenBy(e => e.Nombre);

        foreach (var e in tabla)
        {
            Console.WriteLine($"{e.Nombre} {e.TP}");
        }
    }
}