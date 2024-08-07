namespace AsyncYAwait
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Inicio del Programa");

            //llamar el metodo asincrono
            string resultado = await ObtenerDatosDeRed();

            Console.WriteLine($"Datos recibidos: {resultado}");

            Console.WriteLine("Fin del program");
        }

        public static async Task<string> ObtenerDatosDeRed()
        {
            Console.WriteLine("Iniciando la solicitud de datos...");

            //simularcion de una operacion asincrona con Task.Delay
            await Task.Delay(3000);//segundos

            return "Datos de ejemplo";
        }
    }
}
