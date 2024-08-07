namespace Polimorfismo
{
    public abstract class Forma
    {
        //metodo abstracto que debe se implentado por las clases derivadas
        public abstract void Dibujar();
    }

    //clases derivadas
    public class Circulo : Forma
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un Circulo");
        }
    }

    public class Cuadradro : Forma
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un Cuadrado");
        }
    }

    public class Triangulo : Forma
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un Triangulo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Forma[] formas = new Forma[]
            {
                new Circulo(),
                new Cuadradro(),
                new Triangulo()
            };
            foreach (Forma forma in formas)
            {
                forma.Dibujar();//aca acciona el polimorfismo
            }
        }
    }
}
