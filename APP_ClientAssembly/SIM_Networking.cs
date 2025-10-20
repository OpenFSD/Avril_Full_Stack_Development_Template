using OpenTK;
using OpenTK.Input;
using System.IO.Pipes;

namespace SIMULATION
{
    class SIM_AlgorithmsOnCLient
    {
        public SIM_AlgorithmsOnCLient()
        {

        }

        static public void Calc_praise1(Avril_FSD.ClientAssembly.Framework_Client obj, Avril_FSD.ClientAssembly.Inputs.Input input, Avril_FSD.ClientAssembly.Game_Instance gameInstance)
        {
            Console.WriteLine("TESTBENCH => HandleMouse");
            Avril_FSD.ClientAssembly.Praise_Files.Praise1_Input inputSubset = (Avril_FSD.ClientAssembly.Praise_Files.Praise1_Input)input.Get_praiseInputBuffer_Subset();
            if (obj.Get_client().Get_data().Get_data_Control().Get_isPraiseActive(1) == false)
            {
                if (gameInstance.Get_gameObjectFactory().Get_player().Get_IsFirstMouseMove())
                {
                    gameInstance.Get_gameObjectFactory().Get_player().Set_MousePos(new Vector2(inputSubset.Get_Mouse_X(), inputSubset.Get_Mouse_Y()));
                    gameInstance.Get_gameObjectFactory().Get_player().Set_IsFirstMouseMove(false);
                }
                else
                {
                    switch (gameInstance.Get_cameraSelector())
                    {
                    case false:
                        if ((inputSubset.Get_Mouse_X() != (float)(obj.Get_client().Get_data().Get_settings().Get_ScreenSize_X() / 2))
                            || (inputSubset.Get_Mouse_Y() != (float)(obj.Get_client().Get_data().Get_settings().Get_ScreenSize_Y() / 2)))
                        {
                            float sensitivity = gameInstance.Get_gameObjectFactory().Get_player().Get_sensitivity();
                            float anglePerPixle = obj.Get_client().Get_data().Get_settings().Get_fov() / obj.Get_client().Get_data().Get_settings().Get_ScreenSize_Y();
                            float deltaX = anglePerPixle * (inputSubset.Get_Mouse_X() - (obj.Get_client().Get_data().Get_settings().Get_ScreenSize_X() / 2));
                            float deltaY = anglePerPixle * (inputSubset.Get_Mouse_Y() - (obj.Get_client().Get_data().Get_settings().Get_ScreenSize_Y() / 2));
                            System.Console.WriteLine("TESTBENCH => deltaX = " + deltaX + "  deltaY = " + deltaY);

                            gameInstance.Get_gameObjectFactory().Get_player().Get_CameraFP().Update_Yaw(deltaX);
                            gameInstance.Get_gameObjectFactory().Get_player().Get_CameraFP().Update_Pitch(deltaY);

                            gameInstance.Get_gameObjectFactory().Get_player().Get_CameraFP().UpdateVectors(gameInstance.Get_gameObjectFactory().Get_player().Get_CameraFP().Get_Pitch(), gameInstance.Get_gameObjectFactory().Get_player().Get_CameraFP().Get_Yaw());

                                gameInstance.Get_gameObjectFactory().Get_player().Set_MousePos(new Vector2((obj.Get_client().Get_data().Get_settings().Get_ScreenSize_X() / 2), (obj.Get_client().Get_data().Get_settings().Get_ScreenSize_Y() / 2)));
                        }
                        break;

                    case true:

                        break;
                    }

                }
                Console.WriteLine("TESTBENCH => HandleMouse .. Done");
            }
        }
    }

    class SIM_NetworkingIO
    {
        static private NamedPipeClientStream _client_Send = null;
        static private NamedPipeClientStream _client_Recieve = null;
        public SIM_NetworkingIO() 
        { 
        
        }
        static public void Initialise_Client_Send()
        {
            _client_Send = new NamedPipeClientStream(".", "Avril_FSD_Pipe", PipeDirection.Out);
        }
        static public void Initialise_Client_Recieve()
        {
            _client_Recieve = new NamedPipeClientStream(".", "Avril_FSD_Pipe", PipeDirection.In);
        }
        static public void Do_Client_Send(Avril_FSD.ClientAssembly.Framework_Client obj)
        {
            
            _client_Send.Connect();
            byte praiseEventId = obj.Get_client().Get_data().Get_input_Instnace().Get_BACK_inputDoubleBuffer(obj).Get_praiseEventId();
            byte playerId = obj.Get_client().Get_data().Get_input_Instnace().Get_BACK_inputDoubleBuffer(obj).Get_playerId();
            switch (praiseEventId)
            {
            // USER IMPLAEMENTATION - ABCDE
            case 0:

                break;

            case 1:
                byte[] buffer = new byte[10];
                buffer[0] = praiseEventId;
                buffer[1] = playerId;
                Avril_FSD.ClientAssembly.Praise_Files.Praise1_Input subset = (Avril_FSD.ClientAssembly.Praise_Files.Praise1_Input)obj.Get_client().Get_data().Get_input_Instnace().Get_BACK_inputDoubleBuffer(obj).Get_praiseInputBuffer_Subset();
                byte[] byteArray = BitConverter.GetBytes(subset.Get_Mouse_X());
                for (ushort index = 0; index < 4; index++)
                {
                    buffer[index + 2] = byteArray[index];
                }
                byteArray = BitConverter.GetBytes(subset.Get_Mouse_Y());
                for (ushort index = 0; index < 4; index++)
                {
                    buffer[index + 6] = byteArray[index];
                }
                _client_Send.Write(buffer, 0, buffer.Length);
                break;
            }
            _client_Send.Close();
        }

        static public void Do_Client_Recieve(Avril_FSD.ClientAssembly.Framework_Client obj)
        {
            
            _client_Recieve.Connect();
            Avril_FSD.Library_For_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.Write_Start(obj.Get_client().Get_execute().Get_program_WriteQue_C_OR(), 1);

            byte[] buffer = new byte[1];
            int bytesRead = _client_Recieve.Read(buffer, 0, buffer.Length);
            byte priaseEventId = buffer[0];
            obj.Get_client().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj).Set_praiseEventId(priaseEventId);

            buffer = new byte[1];
            bytesRead = _client_Recieve.Read(buffer, 1, buffer.Length);
            byte playerId = buffer[1];
            obj.Get_client().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj).Set_playerId(playerId);

            switch (priaseEventId)
            {
            case 0:

                break;

            case 1:

                Avril_FSD.ClientAssembly.Praise_Files.Praise1_Output output_Subset = (Avril_FSD.ClientAssembly.Praise_Files.Praise1_Output)obj.Get_client().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj).Get_praiseOutputBuffer_Subset();
                buffer = new byte[12];
                bytesRead = _client_Recieve.Read(buffer, 2, buffer.Length);
                float temp_X = System.BitConverter.ToSingle(buffer, 0);
                float temp_Y = System.BitConverter.ToSingle(buffer, 4);
                float temp_Z = System.BitConverter.ToSingle(buffer, 8);
                Vector3 temp_Vec = new Vector3(temp_X, temp_Y, temp_Z);
                output_Subset.Set_fowards(temp_Vec);

                buffer = new byte[12];
                bytesRead = _client_Recieve.Read(buffer, 14, buffer.Length);
                temp_X = System.BitConverter.ToSingle(buffer, 0);
                temp_Y = System.BitConverter.ToSingle(buffer, 4);
                temp_Z = System.BitConverter.ToSingle(buffer, 8);
                temp_Vec = new Vector3(temp_X, temp_Y, temp_Z);
                output_Subset.Set_right(temp_Vec);

                buffer = new byte[12];
                bytesRead = _client_Recieve.Read(buffer, 26, buffer.Length);
                temp_X = System.BitConverter.ToSingle(buffer, 0);
                temp_Y = System.BitConverter.ToSingle(buffer, 4);
                temp_Z = System.BitConverter.ToSingle(buffer, 8);
                temp_Vec = new Vector3(temp_X, temp_Y, temp_Z);
                output_Subset.Set_up(temp_Vec);
                break;
            }
            _client_Recieve.Close();
        }
    }
}
