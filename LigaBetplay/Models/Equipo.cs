public class Equipo
{
    public string Nombre { get; set; }
    public int PJ { get; set; }
    public int PG { get; set; }
    public int PE { get; set; }
    public int PP { get; set; }
    public int GF { get; set; }
    public int GC { get; set; }
    public int TP { get; set; }

    public Equipo(string nombre)
    {
        Nombre = nombre;
    }

    public int DiferenciaGoles()
    {
        return GF - GC;
    }
}