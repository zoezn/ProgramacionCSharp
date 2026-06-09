public class Pato : IVolador, INadador, ICuack
{
    public void Volar()
    {
        Console.WriteLine("El pato está volando.");
    }

    public void Nadar()
    {
        Console.WriteLine("El pato está nadando.");
    }

    public void Cuack()
    {
        Console.WriteLine("El pato hace cuack.");
    }
}