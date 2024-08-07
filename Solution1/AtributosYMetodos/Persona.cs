namespace AtributosYMetodos
{
    public class Persona
    {
        // Atributo privado
        private string nombre;

        // Propiedad pública con métodos get y set
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
             
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nombre = value;
                }
                else
                {
                    Console.WriteLine("El nombre no puede estar vacío o ser solo espacios.");
                }
            }
        }

        // Propiedad pública con solo get
        public int Edad { get; private set; }

        // Constructor de la clase
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

  
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Persona
            Persona persona = new Persona("Carolina Martinez Cortes", 5);

            // Mostrar información de la persona
            persona.MostrarInformacion();

            // Cambiar el nombre usando el set de la propiedad Nombre
            persona.Nombre = "Eliana Gutierrez";
     
            persona.MostrarInformacion();

            // Intentar establecer un nombre inválido
            persona.Nombre = ""; 
        }
    }
}

