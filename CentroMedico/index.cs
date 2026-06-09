using System;
using System.Collections.Generic;
using System.Linq;

namespace CentroMedico
{
    // Nodo
    public abstract class BaseSanitaria
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        protected BaseSanitaria(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public abstract int GetCantidadAmbulancias();

        public abstract double GetTiempoAsistencia();

        public string GetDireccion()
        {
            return Direccion;
        }
    }

    // Leaf
    public class Hospital : BaseSanitaria
    {
        public int Ambulancias { get; set; }
        public double TiempoAsistencia { get; set; }

        public Hospital(
            string nombre,
            string direccion,
            int ambulancias,
            double tiempo
        ) : base(nombre, direccion)
        {
            Ambulancias = ambulancias;
            TiempoAsistencia = tiempo;
        }

        public override int GetCantidadAmbulancias()
        {
            return Ambulancias;
        }

        public override double GetTiempoAsistencia()
        {
            return TiempoAsistencia;
        }
    }

    // Leaf
    public class UAP : BaseSanitaria
    {
        public int Ambulancias { get; set; }
        public double TiempoAsistencia { get; set; }

        public UAP(
            string nombre,
            string direccion,
            int ambulancias,
            double tiempo
        ) : base(nombre, direccion)
        {
            Ambulancias = ambulancias;
            TiempoAsistencia = tiempo;
        }

        public override int GetCantidadAmbulancias()
        {
            return Ambulancias;
        }

        public override double GetTiempoAsistencia()
        {
            return TiempoAsistencia;
        }
    }

    // Composite
    public class UA : BaseSanitaria
    {
        private List<BaseSanitaria> bases =
            new List<BaseSanitaria>();

        public UA(
            string nombre,
            string direccion
        ) : base(nombre, direccion)
        {
        }

        public void Agregar(BaseSanitaria baseSanitaria)
        {
            bases.Add(baseSanitaria);
        }

        public void Eliminar(BaseSanitaria baseSanitaria)
        {
            bases.Remove(baseSanitaria);
        }

        public override int GetCantidadAmbulancias()
        {
            return bases.Sum(
                b => b.GetCantidadAmbulancias()
            );
        }

        public override double GetTiempoAsistencia()
        {
            if (!bases.Any())
                return 0;

            return bases.Average(
                b => b.GetTiempoAsistencia()
            );
        }
    }

    class Program
    {
        static void Main()
        {
            Hospital h1 = new Hospital(
                "Hospital Houssay",
                "Av. Maipú 1660",
                5,
                12
            );

            Hospital h2 = new Hospital(
                "Hospital Carrea",
                "Av. Libertador 800",
                4,
                10
            );

            UAP uap1 = new UAP(
                "UAP Norte",
                "San Martín 300",
                2,
                8
            );

            UA vicenteLopezCentro =
                new UA(
                    "Vicente López Centro",
                    "Centro"
                );

            vicenteLopezCentro.Agregar(h1);
            vicenteLopezCentro.Agregar(h2);
            vicenteLopezCentro.Agregar(uap1);

            Console.WriteLine(
                $"Ambulancias: {vicenteLopezCentro.GetCantidadAmbulancias()}"
            );

            Console.WriteLine(
                $"Tiempo promedio: {vicenteLopezCentro.GetTiempoAsistencia()}"
            );
        }
    }
}