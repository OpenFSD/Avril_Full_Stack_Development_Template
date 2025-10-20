//ServerAssembly
using System;
using System.Net.Sockets;
using System.Text;
using Valve.Sockets;

namespace Avril_FSD.ServerAssembly
{
    static class Program
    {
        static private Avril_FSD.ServerAssembly.Framework_Server _framework_ServerAssembly = null;

        static void Main()
        {
            Console.WriteLine("TestBench SIMULATION started");//ToDo TestBench

            
            System.Console.WriteLine("ENTERED => app entry point.");//TestBench
            _framework_ServerAssembly = new Avril_FSD.ServerAssembly.Framework_Server();
            while (_framework_ServerAssembly == null) { /* wait until class created */ }
            _framework_ServerAssembly.Initialise(_framework_ServerAssembly);
            System.Console.WriteLine("Created: Server App Architechture.");//TestBench

        }

        static public Avril_FSD.ServerAssembly.Framework_Server Get_framework_Server()
        {
            return _framework_ServerAssembly;
        }
    }
}