namespace _15_TELAS_GERENCIADOR_DE_CLIENTES
{
    internal class Program
    {
        public static List<Cliente> clientes = new List<Cliente>();

        [STAThread]
        static void Main()
        {
            
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}