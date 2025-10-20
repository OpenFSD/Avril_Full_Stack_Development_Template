using System;
using System.Data.Common;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Valve.Sockets;

namespace Avril_FSD.ServerAssembly
{
    public class Networking_Server
    {
        static private NetworkingSockets _server = new NetworkingSockets();
        static private NetworkingUtils _utils;
        static private uint _connectionList;
        static private uint _pollGroup;

        public Networking_Server()
        {
  
        }

        public void Initialise_networking_Server()
        {
            Valve.Sockets.Library.Initialize();
            _server = new NetworkingSockets();
            while (_server == null) { }
            _utils = new NetworkingUtils();
            while (_utils == null) { }
            _connectionList = 0;
        }
        public uint Get_connectionList()
        {
            return _connectionList;
        }
        public NetworkingSockets Get_server()
        {
            return _server;
        }
        public NetworkingUtils Get_utils()
        {
            return _utils;
        }
        public uint Get_pollGroup()
        {
            return _pollGroup;
        }
    }
}
