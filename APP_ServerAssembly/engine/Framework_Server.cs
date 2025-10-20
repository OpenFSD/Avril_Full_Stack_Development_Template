namespace Avril_FSD.ServerAssembly
{
    public class Framework_Server
    {
        static private Avril_FSD.ServerAssembly.Server _server;
        //private Networking networkingClient;

        private Int16 threadId = 0;

        public Framework_Server() 
        {
            Set_server(new Avril_FSD.ServerAssembly.Server());
            while (Get_server() == null){ /* Wait whileis created */ }
            System.Console.WriteLine("Created = > Avril_FSD.ServerAssembly.Server()");//TESTBENCH
        }
        public void Initialise(Avril_FSD.ServerAssembly.Framework_Server obj)
        {
            System.Console.WriteLine("alpha");//TESTBENCH
            obj.Get_server().Get_algorithms().Initialise(obj.Get_server().Get_global().Get_numberOfCores());
            System.Console.WriteLine("bravo");//TESTBENCH
            obj.Get_server().Get_data().Get_data_Control().Initialise(obj);
            System.Console.WriteLine("charlie");//TESTBENCH
            obj.Get_server().Get_execute().Initialise_NetworkingPipes(obj);
            System.Console.WriteLine("delta");//TESTBENCH
            obj.Get_server().Get_execute().Initialise_Libraries(obj);
            System.Console.WriteLine("foxtrot");//TESTBENCH
            obj.Get_server().Get_execute().Create_And_Run_Graphics(obj);
            System.Console.WriteLine("echo");//TESTBENCH
        }
        static public Avril_FSD.ServerAssembly.Server Get__server()
        {
            return _server;
        }
        public Avril_FSD.ServerAssembly.Server Get_server()
        {
            return _server;
        }
        private void Set_server(Avril_FSD.ServerAssembly.Server value)
        {
            _server = value;
        }
    }
}
