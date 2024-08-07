using System.Net.NetworkInformation;

namespace Herencia
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
        }

        public virtual void Arrancar()
        {
            Console.WriteLine("El vehiculo esta arrancando.");
        }
    }

    //clase derivada
    public class Coche : Vehiculo
    {
        public int Puertas { get; set; }

        public override void Arrancar()
        {
            Console.WriteLine("El coche esta arrancando con un suave ronquido");
        }
    }

    public class Moto : Vehiculo
    {
        public bool TieneSidecar { get; set; }

        public override void Arrancar()
        {
            Console.WriteLine("La moto esta arrancando con un ruido");
        }
    }

    class Program
    {
        static void  Main(string[] args)
        {
            Coche miCoche = new Coche
            {
                Marca = "Toyota",
                Modelo = "Corolla",
                Año = 2021,
                Puertas = 4

            };

            Moto miMoto = new Moto
            {
                Marca = "Harley Davidson",
                Modelo = "Iron 883",
                Año = 2000,
                TieneSidecar = false
            };

            miCoche.MostrarInformacion();
            miCoche.Arrancar();

            miMoto.MostrarInformacion();
            miMoto.Arrancar();
        }
    }
}
