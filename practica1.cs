// 1. Crear una clase Persona que tenga los atributos públicos nombre y apellido.
//    ● Crear una instancia y asignarle valores.
//    ● Mostrar por pantalla los valores asignados.
public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

}

// 2. Crear una clase Vehiculo que tenga los atributos públicos marca, modelo y un atributo privado
//    patente.
//    ● Crear una instancia y asignarle valores; notar que el atributo privado no está disponible
//    para la asignación de valores.
//    ● Mostrar por pantalla los valores asignados.
public class Vehiculo
{
    public string Marca { get; set; }

    public string Modelo { get; set; }

    private string patente { get; }

}
// 3. Crear una clase Articulo que tenga los atributos privados marca y modelo.
//    ● Crear métodos públicos para la asignación de valores.
//    ● Crear una instancia y asignarle valores.
//    ● Notar que no es posible mostrar los valores por pantalla y analizar el motivo por lo que
//    esto ocurre.
public class Articulo
{
    private string Marca;
    private string Modelo;

    public Articulo(string marca, string modelo)
    {
        this.Marca = marca;
        this.Modelo = modelo;
    }
}
// 4. Crear una clase Cine que tenga los atributos privados película y horario:
//    ● Crear métodos públicos para la asignación y recuperación de valores.
//    ● Crear un método público obtenerCartelera() que devuelva el nombre de la película y el
//    horario.
//    ● Crear una instancia y asignarle valores.
//    ● Mostrar por pantalla los valores.

public class Cine
{
    private string pelicula { get; set; }
    private string horario { get; set; }

    public Cine(string a, string b)
    {
        this.pelicula = a;
        this.horario = b;
    }
    public override string ToString() => $"{pelicula} - {horario}";
}

// 5. Crear una clase Cine que tenga los atributos privados película y horario.
//    ● Crear métodos públicos para la asignación y recuperación de valores.
//    ● Crear una instancia y asignarle valores.
//    ● Mostrar por pantalla los valores.
//    ● Crear una segunda instancia y asignarle valores.
//    ● Mostrar por pantalla los valores.
//    ● Cambiar los valores de la primera instancia.
//    ● Mostrar en pantalla los valores de ambas instancias; concluir que la instrucción new crea
//    objetos distintos.

class Program
{
    static void Main()
    {
        Persona pinkPantheress = new Persona { Nombre = "Pink", Apellido = "Pantheress" };
        Console.WriteLine($"{pinkPantheress.Nombre} {pinkPantheress.Apellido}");
        Console.WriteLine($"-------------------------------------------");

        Vehiculo auto = new Vehiculo { Marca = "Fiat", Modelo = "123" };
        Console.WriteLine($"{auto.Marca} {auto.Modelo}");
        Console.WriteLine($"-------------------------------------------");

        Articulo articulo = new Articulo("Ala", "Jabon");
        // Console.WriteLine($"{articulo.Marca} {articulo.Modelo}");
        // 'Articulo.Marca' is inaccessible due to its protection level
        // 'Articulo.Modelo' is inaccessible due to its protection level
        Console.WriteLine($"-------------------------------------------");

        Cine cine = new Cine("Mulan", "20:30");
        Console.WriteLine($"{cine.ToString()}");
        Console.WriteLine($"-------------------------------------------");

        Cine cine = new Cine("Mulan", "20:30");
        Console.WriteLine($"{cine.ToString()}");
        //    ● Crear una segunda instancia y asignarle valores.
        //    ● Mostrar por pantalla los valores.
        //    ● Cambiar los valores de la primera instancia.
        //    ● Mostrar en pantalla los valores de ambas instancias; concluir que la instrucción new crea
        //    objetos distintos.
        Console.WriteLine($"-------------------------------------------");
        Cine cine2 = new Cine("Orgullo y prejuicio", "22:30");
        Console.WriteLine($"{cine2.ToString()}");

        Console.WriteLine($"{cine.ToString()}");

    }
}