namespace ConstructoresYSobreescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehiculo = new Vehiculo("Fiat");
            var auto = new Auto("Fiat", "Fiesta"); // pide los dos parametros el del padre y el del hijo
            vehiculo.Conducir();
            auto.Conducir();
        }
    }
}
