using System;

namespace TESTBENCH_LIBs_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("started TESTBENCH.");
//CLIENT
            IntPtr programId_ConcurrentQue_C = Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT.Initialise_LaunchEnableForConcurrentThreadsAt();
            Console.WriteLine("created Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT");

            IntPtr programId_WriteQue_C_IA = Avril_FSD.Library_For_WriteEnableForThreadsAt_CLIENTINPUTACTION.Initialise_WriteEnable();
            Console.WriteLine("created Library_For_WriteEnableForThreadsAt_CLIENTINPUTACTION");

            IntPtr programId_WriteQue_C_OR = Avril_FSD.Library_For_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.Initialise_WriteEnable();
            Console.WriteLine("created Library_For_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE");


            //SERVER
            //IntPtr program_ServerConcurrnecy = Avril_FSD.Library_For_Server_Concurrency.Initialise_Server_Concurrency();
            Console.WriteLine("end TESTBENCH.");
            while (true) { }
        }
    }
}
