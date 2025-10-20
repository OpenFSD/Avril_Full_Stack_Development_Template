using OpenTK;
using Valve.Sockets;

namespace Avril_FSD.ServerAssembly
{
    public class IO_Listen_Respond
    {
        private Avril_FSD.ServerAssembly.IO_Listen_Respond_Control _io_Control;
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
            Set_io_Control(new Avril_FSD.ServerAssembly.IO_Listen_Respond_Control());
            while (Get_io_Control() == null) { }
        }

        public void Thread_Input_Listen()
        {
            Set_listen_CoreId(0);
            Avril_FSD.ServerAssembly.Framework_Server obj = Avril_FSD.ServerAssembly.Program.Get_framework_Server();
            bool done_once = true;
            while (obj.Get_server().Get_execute().Get_execute_Control().Get_flag_ThreadInitialised(Get_listen_CoreId()) == true)
            {
                if (done_once == true)
                {

                    obj.Get_server().Get_execute().Get_execute_Control().Set_flag_ThreadInitialised(Get_listen_CoreId(), false);
                    done_once = false;
                }
            }
            System.Console.WriteLine("Thread Initalised => Thread_Input_Listen()");//TestBench
            while (obj.Get_server().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == true)
            {

            }
            System.Console.WriteLine("Thread Starting => Thread_Input_Listen()");//TestBench
            if (obj.Get_server().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == false)//todo while
            {
                //NetworkingSockets server = new NetworkingSockets();

                uint pollGroup = obj.Get_server().Get_execute().Get_networking_Server().Get_server().CreatePollGroup();

                StatusCallback status = (ref StatusInfo info) => {
                    switch (info.connectionInfo.state)
                    {
                        case ConnectionState.None:
                            break;

                        case ConnectionState.Connecting:
                            obj.Get_server().Get_execute().Get_networking_Server().Get_server().AcceptConnection(info.connection);
                            obj.Get_server().Get_execute().Get_networking_Server().Get_server().SetConnectionPollGroup(pollGroup, info.connection);
                            break;

                        case ConnectionState.Connected:
                            Console.WriteLine("Client connected - ID: " + info.connection + ", IP: " + info.connectionInfo.address.GetIP());
                            break;

                        case ConnectionState.ClosedByPeer:
                        case ConnectionState.ProblemDetectedLocally:
                            obj.Get_server().Get_execute().Get_networking_Server().Get_server().CloseConnection(info.connection);
                            Console.WriteLine("Client disconnected - ID: " + info.connection + ", IP: " + info.connectionInfo.address.GetIP());
                            break;
                    }
                };

                obj.Get_server().Get_execute().Get_networking_Server().Get_utils().SetStatusCallback(status);

                Address address = new Address();
                address.SetAddress("192.168.8.100", 27000);

                uint listenSocket = obj.Get_server().Get_execute().Get_networking_Server().Get_server().CreateListenSocket(ref address);

#if VALVESOCKETS_SPAN
	MessageCallback message = (in NetworkingMessage netMessage) => {
		Console.WriteLine("Message received from - ID: " + netMessage.connection + ", Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
	};
#else
                const int maxMessages = 20;

                NetworkingMessage[] netMessages = new NetworkingMessage[maxMessages];
#endif

                while (!Console.KeyAvailable)
                {
                    obj.Get_server().Get_execute().Get_networking_Server().Get_server().RunCallbacks();

#if VALVESOCKETS_SPAN
		server.ReceiveMessagesOnPollGroup(pollGroup, message, 20);
#else
                    int netMessagesCount = obj.Get_server().Get_execute().Get_networking_Server().Get_server().ReceiveMessagesOnPollGroup(pollGroup, netMessages, maxMessages);

                    if (netMessagesCount > 0)
                    {
                        Avril_FSD.Library_For_WriteEnableForThreadsAt_SERVERINPUTACTION.Write_Start(Avril_FSD.Library_For_Server_Concurrency.Get_program_WriteEnableStack_ServerInputAction(), Get_listen_CoreId());
                        for (int i = 0; i < netMessagesCount; i++)
                        {
                            ref NetworkingMessage netMessage = ref netMessages[i];

                            Console.WriteLine("Message received from - ID: " + netMessage.connection + ", Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
// user implementation \/ below \/
                            byte[] buffer = new byte[1024];
                            netMessage.CopyTo(buffer);
                            Avril_FSD.ServerAssembly.Inputs.Input input = obj.Get_server().Get_data().Get_input_Instnace().Get_FRONT_inputDoubleBuffer(obj);
                            var in_subset = (Avril_FSD.ServerAssembly.Praise_Files.Praise1_Input)input.Get_praiseInputBuffer_Subset();
                            input.Set_praiseEventId(buffer[0]);
                            input.Set_in_playerId(buffer[1]);
                            input.Get_input_Control().SelectSetIntputSubset(obj, input.Get_praiseEventId());
                            switch (input.Get_praiseEventId())
                            {
                                case 0:
                                    break;

                                case 1:
                                    in_subset.Set_Mouse_X(BitConverter.ToSingle(buffer, 2));
                                    in_subset.Set_Mouse_Y(BitConverter.ToSingle(buffer, 6));
                                    break;
                            }
                            var output = obj.Get_server().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj);
                            output.Get_output_Control().SelectSetOutputSubset(obj, input.Get_praiseEventId());
                            output.Set_praiseEventId(input.Get_praiseEventId());
                            output.Set_out_playerId(input.Get_in_playerId());
                            

                            Avril_FSD.ServerAssembly.GameInstance.Player selectedPlayer = obj.Get_server().Get_data().Get_gameInstance().Get_gameObjectFactory().Get_player();
                            float[] mousePosition = new float[2];
                            if (selectedPlayer.Get_isFirstMouseMove())
                            {
                                mousePosition[0] = in_subset.Get_Mouse_X();
                                mousePosition[1] = in_subset.Get_Mouse_Y();
                                selectedPlayer.Set_MousePos(mousePosition);
                                selectedPlayer.Set_isFirstMouseMove(false);
                            }
                            else
                            {
                                switch (obj.Get_server().Get_data().Get_gameInstance().Get_cameraSelector())
                                {
                                    case false:
                                        if ((in_subset.Get_Mouse_X() != (float)(obj.Get_server().Get_data().Get_settings().Get_ScreenSize_X() / 2))
                                            || (in_subset.Get_Mouse_Y() != (float)(obj.Get_server().Get_data().Get_settings().Get_ScreenSize_Y() / 2)))
                                        {
                                            float sensitivity = selectedPlayer.Get_sensitivity();
                                            float anglePerPixle = obj.Get_server().Get_data().Get_settings().Get_fov() / obj.Get_server().Get_data().Get_settings().Get_ScreenSize_Y();
                                            float deltaX = anglePerPixle * (in_subset.Get_Mouse_X() - (obj.Get_server().Get_data().Get_settings().Get_ScreenSize_X() / 2));
                                            float deltaY = anglePerPixle * (in_subset.Get_Mouse_Y() - (obj.Get_server().Get_data().Get_settings().Get_ScreenSize_Y() / 2));
                                            selectedPlayer.Get_CameraFP().Update_Yaw(deltaX);
                                            selectedPlayer.Get_CameraFP().Update_Pitch(deltaY);
                                            selectedPlayer.Get_CameraFP().UpdateVectors(selectedPlayer.Get_CameraFP().Get_Pitch(), selectedPlayer.Get_CameraFP().Get_Yaw());
                                            mousePosition[0] = (obj.Get_server().Get_data().Get_settings().Get_ScreenSize_X() / 2);
                                            mousePosition[1] = (obj.Get_server().Get_data().Get_settings().Get_ScreenSize_Y() / 2);
                                            selectedPlayer.Set_MousePos(mousePosition);
                                        }
                                        break;

                                    case true:

                                        break;
                                }
                                switch (output.Get_praiseEventId())
                                {
                                    case 0:
                                        break;

                                    case 1:
                                        var out_subset = (Avril_FSD.ServerAssembly.Praise_Files.Praise1_Output)output.GetOutputBufferSubset();
                                        out_subset.Set_fowards(selectedPlayer.Get_CameraFP().Get_fowards());
                                        out_subset.Set_right(selectedPlayer.Get_CameraFP().Get_right());
                                        out_subset.Set_up(selectedPlayer.Get_CameraFP().Get_up());
                                        break;
                                }
                                obj.Get_server().Get_data().Flip_OutBufferToWrite(obj);
                                obj.Get_server().Get_data().Get_data_Control().Set_flag_isNewOutputDataReady(true);

                                /*
                                                            Avril_FSD.Library_For_Server_Concurrency.Flip_InBufferToWrite(obj.Get_server().Get_execute().Get_program_ServerConcurrency());
                                                            Avril_FSD.Library_For_Server_Concurrency.Push_Stack_InputPraises(obj.Get_server().Get_execute().Get_program_ServerConcurrency());
                                                            Avril_FSD.Library_For_Server_Concurrency.Set_flag_IsNewOutputDataReady(obj.Get_server().Get_execute().Get_program_ServerConcurrency(), true);
                                                            if (Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_SERVER.Get_Flag_ConcurrentCoreState(obj.Get_server().Get_execute().Get_program_ServerConcurrency(), Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_SERVER.Get_coreId_To_Launch(obj.Get_server().Get_execute().Get_program_ServerConcurrency())) == Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_SERVER.Get_Flag_Idle(obj.Get_server().Get_execute().Get_program_ServerConcurrency()))
                                                            {
                                                                Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_SERVER.Request_Wait_Launch(obj.Get_server().Get_execute().Get_program_ServerConcurrency(), Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_SERVER.Get_coreId_To_Launch(obj.Get_server().Get_execute().Get_program_ServerConcurrency()));
                                                            }
                                */
                                // user implementation /\ above /\

                            }
                            netMessage.Destroy();
                            Avril_FSD.Library_For_WriteEnableForThreadsAt_SERVERINPUTACTION.Write_End(Avril_FSD.Library_For_Server_Concurrency.Get_program_WriteEnableStack_ServerInputAction(), Get_listen_CoreId());
                        }
                    }
#endif

                    Thread.Sleep(15);
                }
                obj.Get_server().Get_execute().Get_networking_Server().Get_server().DestroyPollGroup(pollGroup);
            }
        }
       

        public void Thread_Output_Respond()
        {
            Set_respond_CoreId(1);
            Avril_FSD.ServerAssembly.Framework_Server obj = Avril_FSD.ServerAssembly.Program.Get_framework_Server();
            bool done_once = true;
            while (obj.Get_server().Get_execute().Get_execute_Control().Get_flag_ThreadInitialised(Get_respond_CoreId()) == true)
            {
                if (done_once == true)
                {
                    obj.Get_server().Get_execute().Get_execute_Control().Set_flag_ThreadInitialised(Get_respond_CoreId(), false);
                    done_once = false;
                }
            }
            System.Console.WriteLine("Thread Initalised => Thread_Output_Respond()");//TestBench
            while (obj.Get_server().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == true)
            {

            }
            System.Console.WriteLine("Thread Starting => Thread_Output_Respond()");//TestBench
            while (obj.Get_server().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == false)
            {
                StatusCallback status = (ref StatusInfo info) => {
                    switch (info.connectionInfo.state)
                    {
                        case ConnectionState.None:
                            break;

                        case ConnectionState.Connecting:
                            obj.Get_server().Get_execute().Get_networking_Server().Get_server().AcceptConnection(info.connection);
                            obj.Get_server().Get_execute().Get_networking_Server().Get_server().SetConnectionPollGroup(obj.Get_server().Get_execute().Get_networking_Server().Get_pollGroup(), info.connection);
                            break;

                        case ConnectionState.Connected:
                            Console.WriteLine("Client connected - ID: " + info.connection + ", IP: " + info.connectionInfo.address.GetIP());
                            break;

                        case ConnectionState.ClosedByPeer:
                        case ConnectionState.ProblemDetectedLocally:
                            obj.Get_server().Get_execute().Get_networking_Server().Get_server().CloseConnection(info.connection);
                            Console.WriteLine("Client disconnected - ID: " + info.connection + ", IP: " + info.connectionInfo.address.GetIP());
                            break;
                    }
                };

                obj.Get_server().Get_execute().Get_networking_Server().Get_utils().SetStatusCallback(status);

#if VALVESOCKETS_SPAN
	MessageCallback message = (in NetworkingMessage netMessage) => {
		Console.WriteLine("Message received from - ID: " + netMessage.connection + ", Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
	};
#else
                const int maxMessages = 20;

                NetworkingMessage[] netMessages = new NetworkingMessage[maxMessages];
#endif

                while (!Console.KeyAvailable)
                {
                    obj.Get_server().Get_execute().Get_networking_Server().Get_server().RunCallbacks();

#if VALVESOCKETS_SPAN
		server.ReceiveMessagesOnPollGroup(pollGroup, message, 20);
#else
                    int netMessagesCount = obj.Get_server().Get_execute().Get_networking_Server().Get_server().ReceiveMessagesOnPollGroup(obj.Get_server().Get_execute().Get_networking_Server().Get_pollGroup(), netMessages, maxMessages);

                    if (netMessagesCount > 0)
                    {
                        Avril_FSD.Library_For_WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE.Write_Start(Avril_FSD.Library_For_Server_Concurrency.Get_program_WriteEnableStack_ServerOutputRecieve(), Get_respond_CoreId());
                        for (int i = 0; i < netMessagesCount; i++)
                        {
                            obj.Get_server().Get_data().Get_data_Control().Pop_Stack_OutputRecieve(obj.Get_server().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj), obj.Get_server().Get_data().Get_stack_Client_OutputRecieves());
                            obj.Get_server().Get_data().Flip_OutBufferToWrite(obj);

                            ref NetworkingMessage netMessage = ref netMessages[i];

                            Console.WriteLine("Message received from - ID: " + netMessage.connection + ", Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
                            // user implementation \/ below \/
                            byte[] data = new byte[64];

                            var output = obj.Get_server().Get_data().Get_output_Instnace().Get_FRONT_outputDoubleBuffer(obj);
                            data[0] = output.Get_praiseEventId();
                            data[1] = output.Get_out_playerId();
                            switch (output.Get_praiseEventId())
                            {
                                case 0:
                                    break;

                                case 1:
                                    var subset = (Avril_FSD.ServerAssembly.Praise_Files.Praise1_Output)output.GetOutputBufferSubset();
                                    byte[] tempFloat = BitConverter.GetBytes(subset.Get_fowards().X);
                                    for (byte index = 0; index < tempFloat.Length; index++)
                                    {
                                        data[index + 2] = tempFloat[index];
                                    }
                                    tempFloat = BitConverter.GetBytes(subset.Get_fowards().Y);
                                    for (byte index = 0; index < tempFloat.Length; index++)
                                    {
                                        data[index + 6] = tempFloat[index];
                                    }
                                    tempFloat = BitConverter.GetBytes(subset.Get_fowards().Z);
                                    for (byte index = 0; index < tempFloat.Length; index++)
                                    {
                                        data[index + 10] = tempFloat[index];
                                    }
                                    tempFloat = BitConverter.GetBytes(subset.Get_right().X);
                                    for (byte index = 0; index < tempFloat.Length; index++)
                                    {
                                        data[index + 14] = tempFloat[index];
                                    }
                                    tempFloat = BitConverter.GetBytes(subset.Get_right().Y);
                                    for (byte index = 0; index < tempFloat.Length; index++)
                                    {
                                        data[index + 18] = tempFloat[index];
                                    }
                                    tempFloat = BitConverter.GetBytes(subset.Get_right().Z);
                                    for (byte index = 0; index < tempFloat.Length; index++)
                                    {
                                        data[index + 22] = tempFloat[index];
                                    }
                                    tempFloat = BitConverter.GetBytes(subset.Get_up().X);
                                    for (byte index = 0; index < tempFloat.Length; index++)
                                    {
                                        data[index + 26] = tempFloat[index];
                                    }
                                    tempFloat = BitConverter.GetBytes(subset.Get_up().Y);
                                    for (byte index = 0; index < tempFloat.Length; index++)
                                    {
                                        data[index + 30] = tempFloat[index];
                                    }
                                    tempFloat = BitConverter.GetBytes(subset.Get_up().Z);
                                    for (byte index = 0; index < tempFloat.Length; index++)
                                    {
                                        data[index + 34] = tempFloat[index];
                                    }
                                    break;

                            }
                            obj.Get_server().Get_execute().Get_networking_Server().Get_server().SendMessageToConnection(obj.Get_server().Get_execute().Get_networking_Server().Get_connectionList(), data);
// user implementation /\ above /\
                            netMessage.Destroy();
                        }
                        Avril_FSD.Library_For_WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE.Write_End(Avril_FSD.Library_For_Server_Concurrency.Get_program_WriteEnableStack_ServerOutputRecieve(), Get_respond_CoreId());
                    }
#endif

                    Thread.Sleep(15);
                }

                obj.Get_server().Get_execute().Get_networking_Server().Get_server().DestroyPollGroup(obj.Get_server().Get_execute().Get_networking_Server().Get_pollGroup());
            }/*
            if (Avril_FSD.Library_For_Server_Concurrency.Get_flag_IsStackLoaded_Server_OutputRecieve(obj.Get_server().Get_execute().Get_program_ServerConcurrency()))
                {/
                    Avril_FSD.Library_For_WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE.Write_Start(Avril_FSD.Library_For_Server_Concurrency.Get_program_WriteEnableStack_ServerOutputRecieve(), Get_respond_CoreId());
                    while(Avril_FSD.Library_For_Server_Concurrency.Get_flag_IsStackLoaded_Server_OutputRecieve(obj.Get_server().Get_execute().Get_program_ServerConcurrency()))
                    {
                        SIMULATION.SIM_NetworkingIO.Do_Server_Send(obj);
                    }
                    Avril_FSD.Library_For_WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE.Write_End(Avril_FSD.Library_For_Server_Concurrency.Get_program_WriteEnableStack_ServerOutputRecieve(), Get_respond_CoreId());
                }
            }*/
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
