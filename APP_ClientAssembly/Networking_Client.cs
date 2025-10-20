using System;
using System.Collections;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Valve.Sockets;


namespace Avril_FSD.ClientAssembly
{
    public class Networking_Client
    {
        static private NetworkingSockets _client;
        static private NetworkingUtils _utils;
        static private uint _connectionList;

        public Networking_Client()
        {
            
        }

        public void Initialise_networking_Client()
        {
            Valve.Sockets.Library.Initialize();
            _client = new NetworkingSockets();
            _utils = new NetworkingUtils();
            _connectionList = 0;
        }
         
        public NetworkingSockets Get_client()
        {
            return _client;
        }
        public NetworkingUtils Get_utils()
        {
            return _utils;
        }
        public uint Get_connectionList()
        {
            return _connectionList;
        }

        public void Set_connection(uint connection)
        {
            _connectionList = connection;
        }
    }
}
