namespace Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }


        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }


        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
        }


        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Persona persona1 = new Persona("Carolina Martinez", 16, "Campoalegre");

            persona1.MostrarInformacion();


            if (persona1.EsMayorDeEdad())
            {
                Console.WriteLine("La persona es mayor de edad.");
            }
            else
            {
                Console.WriteLine("La persona es menor de edad.");
            }
        }
    }
}
