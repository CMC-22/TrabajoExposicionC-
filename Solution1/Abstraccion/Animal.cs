namespace Abstraccion
{
    public abstract class Animal
    {
        public string Nombre { get; set; }

        //metodo abstracto que debe ser implementado por las clases derivadas
        public abstract void HacerSonido();

        public void Dormir()
        {
            Console.WriteLine($"{Nombre} esta durmiendo.");
        }
    }

    //clases derivadas
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Guau!");
        }
    }

    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //crea instancias de las clases derivadas
            Animal miPerro = new Perro { Nombre = "Shagy" };
            Animal miGato = new Gato { Nombre = "Salem" };

            miPerro.HacerSonido();
            miGato.HacerSonido();

            miPerro.Dormir();
            miGato.Dormir();
        }
    }
}
