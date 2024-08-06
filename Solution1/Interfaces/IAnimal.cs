using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAnimal
    { 
    string Nombre { get; set; }

    //Metodo que debe ser implementado por las clases
    void HacerSonido();
}

public class Perro : IAnimal
{
    public string Nombre { get; set; }

    public void HacerSonido()
    {
        Console.WriteLine("El perro hace: ¡Gua!");
    }
}

public class Gato : IAnimal
{
    public string Nombre { get; set; }
    public void HacerSonido()
    {
        Console.WriteLine("El gato hace: ¡Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal miPerro = new Perro { Nombre = "Shagy" };
        IAnimal miGato = new Gato { Nombre = "Salem" };

        miPerro.HacerSonido();
        miGato.HacerSonido();

        Console.WriteLine($"Nombre del perro: {miPerro.Nombre}");
        Console.WriteLine($"Nombre del gato: {miGato.Nombre}");
    }
}
}
