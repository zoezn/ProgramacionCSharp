public class Persona
{
    public int Id { get; }
    public string Name { get; }
    public Persona(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public string SayHi() => $"Hola {Name}";
    public string GetKey() => Id.ToString();
    public override string ToString() => $"{Id} - {Name}";
}
class Program
{
    static void Main()
    {
        var unicos = new GenericSet<Persona>(p => p.GetKey());
        unicos.Add(new Persona(1, "Juan"));
        unicos.Add(new Persona(1, "Juan")); // Ignorado, ya existe
        foreach (var p in unicos.Values())
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("----------------------------------------");
        var p3 = new Persona(3, "Ana");
        var arrayUnicos = new List<Persona>
        {
        new Persona(1, "Pedro"),
        new Persona(2, "Fede"),
        p3,
        new Persona(4, "Laura")
        };
        var unicos2 = new GenericSet<Persona>(a => a.GetKey(), arrayUnicos);
        unicos2.ForEach((x, i, arr) => Console.WriteLine($"{i}: {x}"));
        unicos2.Delete(p3);
        unicos2.ForEach((x, i, arr) => Console.WriteLine($"{i}: {x}"));
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Un elemento: {unicos2.Get("2")}");
    }
}