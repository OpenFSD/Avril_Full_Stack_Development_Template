using OpenTK;
using Valve.Sockets;

namespace Avril_FSD.ClientAssembly
{ 
    public class IO_Listen_Respond
    {
        private Avril_FSD.ClientAssembly.IO_Listen_Respond_Control _io_Control;
        private byte _listen_CoreId;
        private byte _respond_CoreId;
        
        public IO_Listen_Respond() 
        {
            Set_io_Control(null);
            Set_listen_CoreId(255);
            Set_respond_CoreId(255);
        }
        public void InitialiseControl()
        {
            Set_io_Control(new Avril_FSD.ClientAssembly.IO_Listen_Respond_Control());
            while (Get_io_Control() == null) { }
        }

        public void Thread_Input_Send()
        {
            Avril_FSD.ClientAssembly.Framework_Client obj = Avril_FSD.ClientAssembly.Program.Get_framework_Client();
            bool done_once = true;
            while (obj.Get_client().Get_execute().Get_execute_Control().Get_flag_ThreadInitialised(Get_listen_CoreId()) == true)
            {
                if (done_once == true)
                {
                    obj.Get_client().Get_execute().Get_execute_Control().Set_flag_ThreadInitialised(Get_listen_CoreId(), false);
                    done_once = false;
                }
            }
            System.Console.WriteLine("Thread Initalised => Thread_Input_Send()");//TestBench
            while (obj.Get_client().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == true)
            {

            }
            System.Console.WriteLine("Thread Starting => Thread_Input_Send()");//TestBench
            while (obj.Get_client().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == false)
            {
                //NetworkingSockets client = new NetworkingSockets();

                uint connection = obj.Get_client().Get_execute().Get_networking_Client().Get_connectionList();

                StatusCallback status = (ref StatusInfo info) => {
                    switch (info.connectionInfo.state)
                    {
                        case ConnectionState.None:
                            break;

                        case ConnectionState.Connected:
                            Console.WriteLine("Client connected to server - ID: " + connection);
                            break;

                        case ConnectionState.ClosedByPeer:
                        case ConnectionState.ProblemDetectedLocally:
                            obj.Get_client().Get_execute().Get_networking_Client().Get_client().CloseConnection(connection);
                            Console.WriteLine("Client disconnected from server");
                            break;
                    }
                };

                obj.Get_client().Get_execute().Get_networking_Client().Get_utils().SetStatusCallback(status);

                Address address = new Address();

                address.SetAddress("192.168.8.215", 27001);

                connection = obj.Get_client().Get_execute().Get_networking_Client().Get_client().Connect(ref address);

#if VALVESOCKETS_SPAN
	MessageCallback message = (in NetworkingMessage netMessage) => {
		Console.WriteLine("Message received from server - Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
	};
#else
                const int maxMessages = 20;

                NetworkingMessage[] netMessages = new NetworkingMessage[maxMessages];
#endif
                
                while (!Console.KeyAvailable)
                {
                    obj.Get_client().Get_execute().Get_networking_Client().Get_client().RunCallbacks();

#if VALVESOCKETS_SPAN
		client.ReceiveMessagesOnConnection(connection, message, 20);
#else
                    int netMessagesCount = obj.Get_client().Get_execute().Get_networking_Client().Get_client().ReceiveMessagesOnConnection(connection, netMessages, maxMessages);

                    if (netMessagesCount > 0)
                    {
                        //Avril_FSD.Library_For_WriteEnableForThreadsAt_CLIENTINPUTACTION.Write_Start(obj.Get_client().Get_execute().Get_program_WriteQue_C_IA(), Get_listen_CoreId());
                        for (int i = 0; i < netMessagesCount; i++)
                        {
                            ref NetworkingMessage netMessage = ref netMessages[i];

                            Console.WriteLine("Message received from server - Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
                            
                            while (obj.Get_client().Get_data().Get_data_Control().Get_flag_IsLoaded_Stack_InputAction() == true)
                            {
                                byte[] data = new byte[64];
                                data[0] = obj.Get_client().Get_data().Get_input_Instnace().Get_BACK_inputDoubleBuffer(obj).Get_praiseEventId();
                                data[1] = obj.Get_client().Get_data().Get_input_Instnace().Get_BACK_inputDoubleBuffer(obj).Get_playerId();
                                switch (data[0])
                                {
                                    case 0:

                                        break;

                                    case 1:
                                        var subset = (Avril_FSD.ClientAssembly.Praise_Files.Praise1_Input)obj.Get_client().Get_data().Get_input_Instnace().Get_BACK_inputDoubleBuffer(obj).Get_praiseInputBuffer_Subset();
                                        byte[] byteArray = new byte[4];
                                        byteArray = BitConverter.GetBytes(subset.Get_Mouse_X());
                                        for (byte index = 0; index < 4; index++)
                                        {
                                            data[index+2] = byteArray[index];
                                        }
                                        byteArray = BitConverter.GetBytes(subset.Get_Mouse_Y());
                                        for (byte index = 0; index < 4; index++)
                                        {
                                            data[index + 6] = byteArray[index];
                                        }
                                        break;
                                }
                                obj.Get_client().Get_execute().Get_networking_Client().Get_client().SendMessageToConnection(connection, data);
                            }
                            netMessage.Destroy();
                        }
                        //Avril_FSD.Library_For_WriteEnableForThreadsAt_CLIENTINPUTACTION.Write_End(obj.Get_client().Get_execute().Get_program_WriteQue_C_IA(), Get_listen_CoreId());
                    }
#endif
                    Thread.Sleep(15);
                }
            }
        }
        public void Thread_Output_Respond()
        {
            Avril_FSD.ClientAssembly.Framework_Client obj = Avril_FSD.ClientAssembly.Program.Get_framework_Client();
            bool done_once = true;
            while (obj.Get_client().Get_execute().Get_execute_Control().Get_flag_ThreadInitialised(Get_respond_CoreId()) == true)
            {
                if (done_once == true)
                {
                    obj.Get_client().Get_execute().Get_execute_Control().Set_flag_ThreadInitialised(Get_respond_CoreId(), false);
                    done_once = false;
                }
            }
            System.Console.WriteLine("Thread Initalised => Thread_Output_Respond()");//TestBench
            while (obj.Get_client().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == true)
            {

            }
            System.Console.WriteLine("Thread Starting => Thread_Output_Respond()");//TestBench
            while (obj.Get_client().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == false)
            {
                StatusCallback status = (ref StatusInfo info) =>
                {
                    switch (info.connectionInfo.state)
                    {
                        case ConnectionState.None:
                            break;

                        case ConnectionState.Connected:
                            Console.WriteLine("Client connected to server - ID: " + obj.Get_client().Get_execute().Get_networking_Client().Get_connectionList());
                            break;

                        case ConnectionState.ClosedByPeer:
                        case ConnectionState.ProblemDetectedLocally:
                            obj.Get_client().Get_execute().Get_networking_Client().Get_client().CloseConnection(obj.Get_client().Get_execute().Get_networking_Client().Get_connectionList());
                            Console.WriteLine("Client disconnected from server");
                            break;
                    }
                };

                obj.Get_client().Get_execute().Get_networking_Client().Get_utils().SetStatusCallback(status);

                Address address = new Address();

                address.SetAddress("192.168.8.215", 27001);

                obj.Get_client().Get_execute().Get_networking_Client().Set_connection(obj.Get_client().Get_execute().Get_networking_Client().Get_client().Connect(ref address));

#if VALVESOCKETS_SPAN
	MessageCallback message = (in NetworkingMessage netMessage) => {
		Console.WriteLine("Message received from server - Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
	};
#else
                const int maxMessages = 20;

                NetworkingMessage[] netMessages = new NetworkingMessage[maxMessages];
#endif

                while (!Console.KeyAvailable)
                {
                    obj.Get_client().Get_execute().Get_networking_Client().Get_client().RunCallbacks();

#if VALVESOCKETS_SPAN
		client.ReceiveMessagesOnConnection(connection, message, 20);
#else
                    int netMessagesCount = obj.Get_client().Get_execute().Get_networking_Client().Get_client().ReceiveMessagesOnConnection(obj.Get_client().Get_execute().Get_networking_Client().Get_connectionList(), netMessages, maxMessages);

                    if (netMessagesCount > 0)
                    {
                        //Avril_FSD.Library_For_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.Write_Start(obj.Get_client().Get_execute().Get_program_WriteQue_C_OR(), Get_respond_CoreId());
                        for (int i = 0; i < netMessagesCount; i++)
                        {
                            ref NetworkingMessage netMessage = ref netMessages[i];

                            Console.WriteLine("Message received from server - Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
// user implementation \/ below \/
                            byte[] buffer = new byte[1024];
                            netMessage.CopyTo(buffer);
                            var output = obj.Get_client().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj);
                            output.Get_output_Control().Select_Set_Output_Subset(obj, Get_respond_CoreId(), buffer[0]);
                            output.Set_praiseEventId(buffer[0]);
                            output.Set_playerId(buffer[1]);
                            switch (output.Get_praiseEventId())
                            {
                            case 0:
                                    
                                break; 

                            case 1:
                                var subset = (Avril_FSD.ClientAssembly.Praise_Files.Praise1_Output)output.Get_praiseOutputBuffer_Subset();
                                Vector3 tempVector = new Vector3(0);
                                tempVector.X = BitConverter.ToSingle(buffer, 2);
                                tempVector.Y = BitConverter.ToSingle(buffer, 6);
                                tempVector.Z = BitConverter.ToSingle(buffer, 10);
                                subset.Set_fowards(tempVector);
                                tempVector.X = BitConverter.ToSingle(buffer, 14);
                                tempVector.Y = BitConverter.ToSingle(buffer, 18);
                                tempVector.Z = BitConverter.ToSingle(buffer, 22);
                                subset.Set_right(tempVector);
                                tempVector.X = BitConverter.ToSingle(buffer, 26);
                                tempVector.Y = BitConverter.ToSingle(buffer, 30);
                                tempVector.Z = BitConverter.ToSingle(buffer, 34);
                                subset.Set_up(tempVector);
                                break;
                            }
                            obj.Get_client().Get_data().Flip_OutBufferToWrite();
                            obj.Get_client().Get_data().Get_data_Control().Push_Stack_Client_OutputRecieve(obj.Get_client().Get_data().Get_output_Instnace().Get_stack_Client_OutputRecieves(), obj.Get_client().Get_data().Get_output_Instnace().Get_FRONT_outputDoubleBuffer(obj));
                            obj.Get_client().Get_data().Get_data_Control().Set_flag_isNewOutputDataReady(true);
                            //if (obj.Get_client().Get_data().Get_data_Control().Get_flag_IsLoaded_Stack_OutputRecieve())
                           // {
                           //     if (Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT.Get_State_LaunchBit(obj.Get_client().Get_execute().Get_program_ConcurrentQue_C()))
                           //     {
                           //         Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT.Request_Wait_Launch(obj.Get_client().Get_execute().Get_program_ConcurrentQue_C(), Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT.Get_coreId_To_Launch(obj.Get_client().Get_execute().Get_program_ConcurrentQue_C()));
                           //     }
                           // }

                            // user implementation /\ above /\
                            netMessage.Destroy();
                        }
                        //Avril_FSD.Library_For_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.Write_End(obj.Get_client().Get_execute().Get_program_WriteQue_C_OR(), Get_respond_CoreId());
                    }
#endif

                    Thread.Sleep(15);
                }
            }
        }

        public IO_Listen_Respond_Control Get_io_Control()
        {
            return _io_Control;
        }
        public byte Get_listen_CoreId()
        {
            return _listen_CoreId;
        }
        public byte Get_respond_CoreId()
        {
            return _respond_CoreId;
        }
        public void Set_io_Control(IO_Listen_Respond_Control io_control)
        {
            _io_Control = io_control;
        }
        public void Set_listen_CoreId(byte listen_coreId)
        {
            _listen_CoreId = listen_coreId;
        }
        public void Set_respond_CoreId(byte respond_coreId)
        {
            _respond_CoreId = respond_coreId;
        }
    }
}
