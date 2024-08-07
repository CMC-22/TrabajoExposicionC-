namespace MetodosYFunciones
{
    public class Calculadora
    {
       public int Restar(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Calculadora calc = new Calculadora();

            int resta = calc.Restar(10, 3);

            Console.WriteLine($"Resta: {resta}");
        }
    }
}
