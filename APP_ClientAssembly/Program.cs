namespace Avril_FSD.ClientAssembly
{
    class Program
    {
        static private Avril_FSD.ClientAssembly.Framework_Client framework = null;

        static void Main(string[] args)
        {
            System.Console.WriteLine("started progrma entry.");
            framework = new Avril_FSD.ClientAssembly.Framework_Client();
            while (framework == null) { /* wait untill is created */ }
            framework.Initialise(framework);
        }

        static public Avril_FSD.ClientAssembly.Framework_Client Get_framework_Client()
        {
            return framework;
        }
    }
}
