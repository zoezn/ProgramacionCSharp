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

// 13. El laboratorio Kokumo Technologies está desarrollando el prototipo de un robot explorador cuyo
// sistema de tracción puede ser personalizado para que se adapte mejor al terreno.
// El robot, llamado KT-2020, tiene las siguientes características:
// ● Número de serie: KT-2020-P
// ● Potencia de tracción base (PTB): 10 hp
// ● Tracción: cualquiera de las dos opciones desarrolladas.
// Los sistemas de tracción disponibles son:
// ● Rueda de caucho: ideal para entornos urbanos, su uso le resta 1 hp al PTB y permite el
// rodado de hasta 100 km; cuando se gasta, debe reemplazarse.
// ● Oruga: para todo tipo de terreno, le permite avanzar hasta 400 km antes de requerir
// reemplazo y resta 3 hp al PTB. Incorpora sensores Meke-M0 que le permiten conocer la
// temperatura.
// Analizar, diseñar, diagramar las relaciones e implementar el código.
// Crear instancias de cada una de las clases y asignarle al robot los distintos sistemas de tracción,
// procurando mostrar por pantalla los siguientes datos entre las distintas asignaciones:
// Número de serie, potencia de tracción final, tipo de tracción, cuanto puede avanzar y
// datos sobre cualquier característica adicional que posea.
public class Robot
{
    private string nroDeSerie;
    private int PTB;
    private SistemaDeTraccion traccion;
    private string tipoDeTraccion = "oruga" | "ruedaDeCaucho";
    private SistemaDeTraccion oruga = new SistemaDeTraccion("todo tipo de terreno", 3, 400, true);
    private SistemaDeTraccion ruedaDeCaucho = new SistemaDeTraccion("urbanos", 1, 100, false);

    public Robot(string nroDeSerie, int PTB, string tipoDeTraccion)
    {
        this.nroDeSerie = nroDeSerie;
        this.PTB = PTB;
        this.tipoDeTraccion = tipoDeTraccion;
        if (tipoDeTraccion = "oruga")
        {
            this.traccion = oruga;
        }
        else
        {

        }
    }
}
public class SistemaDeTraccion
{
    private string tipoDeTerreno;
    private int resto;
    private int longitudAvanzable;
    private bool poseeSensoresMekeM0;
    private string caractAdicionales;

    public SistemaDeTraccion(string tipoDeTerreno, int resto, int longitudAvanzable, bool poseeSensoresMekeM0, string caractAdicionales = "")
    {
        this.tipoDeTerreno = tipoDeTerreno;
        this.resto = resto;
        this.longitudAvanzable = longitudAvanzable;
        this.poseeSensoresMekeM0 = poseeSensoresMekeM0;
        this.caractAdicionales = caractAdicionales;
    }
}

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