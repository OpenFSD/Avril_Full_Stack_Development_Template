using System.Data.Common;

namespace Avril_FSD.ServerAssembly
{
    public class Execute
    {
        private Avril_FSD.ServerAssembly.Execute_Control _execute_Control;
        private Avril_FSD.ServerAssembly.Networking_Server _networking_Server;
        private IntPtr _program_ServerConcurrency;
        private Thread[] _threads = {null, null};
        
        public Execute(int numberOfCores) 
        {
            Set_execute_Control(null);
        }

        public void Initialise_Control(int numberOfCores, Global global)
        {
            Set_execute_Control(new Avril_FSD.ServerAssembly.Execute_Control(numberOfCores));
            while (Get_execute_Control() == null) { }
        }

        public void Initialise_Libraries(Avril_FSD.ServerAssembly.Framework_Server obj)
        {
            //obj.Get_server().Get_execute().Set_program_ServerConcurrency(Avril_FSD.Library_For_Server_Concurrency.Initialise_Server_Concurrency());
            System.Console.WriteLine("skipped initialise server concurrency.");//TESTBENCH
        }
        public void Initialise_NetworkingPipes(Avril_FSD.ServerAssembly.Framework_Server obj)
        {
            obj.Get_server().Get_execute().Set_networking_Server(new Avril_FSD.ServerAssembly.Networking_Server());
            obj.Get_server().Get_execute().Get_networking_Server().Initialise_networking_Server();
        }
        public void Initialise_Threads(Avril_FSD.ServerAssembly.Framework_Server obj)
        {
            obj.Get_server().Get_execute().Set_thread(0, new Thread(obj.Get_server().Get_algorithms().Get_io_ListenRespond().Thread_Input_Listen));
            obj.Get_server().Get_algorithms().Get_io_ListenRespond().Set_listen_CoreId(0);
            obj.Get_server().Get_execute().Get_thread(0).Start();
            System.Console.WriteLine("starting = > Set_listen_CoreId on core " + (0).ToString());//TESTBENCH

            obj.Get_server().Get_execute().Set_thread(1, new Thread(obj.Get_server().Get_algorithms().Get_io_ListenRespond().Thread_Output_Respond));
            obj.Get_server().Get_algorithms().Get_io_ListenRespond().Set_respond_CoreId(1);
            obj.Get_server().Get_execute().Get_thread(1).Start();
            System.Console.WriteLine("starting = > Thread_Output_Respond on core " + (1).ToString());//TESTBENCH
        }

        public void Create_And_Run_Graphics(Avril_FSD.ServerAssembly.Framework_Server obj)
        {
            System.Console.WriteLine("starting = > gameInstance");//TESTBENCH
            using (Avril_FSD.ServerAssembly.Game_Instance gameInstance = new Avril_FSD.ServerAssembly.Game_Instance())
            {
                gameInstance.Run(obj.Get_server().Get_data().Get_settings().Get_refreshRate());
            }
        }

        public Avril_FSD.ServerAssembly.Execute_Control Get_execute_Control()
        {
            return _execute_Control;
        }
        public Avril_FSD.ServerAssembly.Networking_Server Get_networking_Server()
        {
            return _networking_Server;
        }

        public Thread Get_thread(int index)
        {
            return _threads[index];
        }
        public IntPtr Get_program_ServerConcurrency()
        {
            return _program_ServerConcurrency;
        }

        private void Set_execute_Control(Avril_FSD.ServerAssembly.Execute_Control execute_Control)
        {
            _execute_Control = execute_Control;
        }
        public void Set_networking_Server(Avril_FSD.ServerAssembly.Networking_Server networking_Server)
        {
            _networking_Server = networking_Server;
        }
        private void Set_thread(byte index, Thread thread) 
        {
            _threads[index] = thread;
        }

        private void Set_program_ServerConcurrency(IntPtr handle)
        {
            _program_ServerConcurrency = handle;
        }
    }   
}
