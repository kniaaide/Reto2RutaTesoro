namespace Reto2RutaTesoro
{
    internal static class Program
    {
        /// <summary>Punto de entrada principal de la aplicación.</summary>
        [STAThread]
        static void Main()
        {
            // Configura DPI, fuentes y estilos visuales por defecto.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmRutaTesoro());
        }
    }
}
