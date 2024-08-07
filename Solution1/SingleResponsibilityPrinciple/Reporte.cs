using System.Security.Cryptography.X509Certificates;

namespace SingleResponsibilityPrinciple
{
    public class Reporte
    {
        public string Contenido { get; set; }
    }

    public class ReporteGenerador
    {
        public Reporte GenerarReporte()
        {
            // Generar el contenido del reporte
            return new Reporte { Contenido = "Contenido del reporte" };
        }
    }

    public class ReporteImpresora
    {
        public void Imprimir(Reporte reporte)
        {
            // Imprimir el reporte
            Console.WriteLine(reporte.Contenido);
        }
    }

}
