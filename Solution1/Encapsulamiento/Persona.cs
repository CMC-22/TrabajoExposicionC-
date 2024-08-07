namespace Encapsulamiento
{
    public class Persona
    {
        private string nombre;
        private int edad;

        // Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // Propiedad pública para acceder al nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // Propiedad pública para acceder a la edad
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0) 
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine("Edad no válida");
                }
            }
        }
    }

  
    class Program
    {
        static void Main()
        {
           
            Persona persona = new Persona("Juan", 30);

            // Acceder y modificar los atributos a través de propiedades públicas
            Console.WriteLine("Nombre: " + persona.Nombre);
            Console.WriteLine("Edad: " + persona.Edad);

           
            persona.Edad = 35;
            Console.WriteLine("Edad actualizada: " + persona.Edad);

    
        }
    }
}

