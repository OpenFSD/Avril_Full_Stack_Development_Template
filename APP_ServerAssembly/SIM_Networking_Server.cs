using System.IO.Pipes;

namespace SIMULATION
{
    class SIM_NetworkingIO
    {
        static private NamedPipeServerStream _server_IO = null;

        public SIM_NetworkingIO() 
        { 
        
        }
        static public void Initialise_Server_IO()
        {
            _server_IO = new NamedPipeServerStream("Avril_FSD_Pipe");
        }
        static public void Do_Server_Recieve(Avril_FSD.ServerAssembly.Framework_Server obj)
        {
            _server_IO.WaitForConnection();
            Avril_FSD.Library_For_WriteEnableForThreadsAt_SERVERINPUTACTION.Write_Start(Avril_FSD.Library_For_Server_Concurrency.Get_program_WriteEnableStack_ServerInputAction(), 0);

            byte[] buffer = new byte[1];
            int bytesRead = _server_IO.Read(buffer, 0, buffer.Length);
            byte praiseEventId = buffer[0];
            Avril_FSD.Library_For_Server_Concurrency.Set_PraiseEventId(obj.Get_server().Get_execute().Get_program_ServerConcurrency(), praiseEventId);//TODO: change to byte

            buffer = new byte[1];
            bytesRead = _server_IO.Read(buffer, 1, buffer.Length);
            byte playerID = buffer[0];
            //Avril_FSD.Library_For_Server_Concurrency.Set_playerId(playerID);//TODO: change to byte

            Avril_FSD.Library_For_Server_Concurrency.Select_Set_Intput_Subset(obj.Get_server().Get_execute().Get_program_ServerConcurrency(), praiseEventId);
            switch (praiseEventId)
            {
                // USER IMPLEMENTATION - ABCDE
                case 0:

                    break;

                case 1:
                    buffer = new byte[8];
                    bytesRead = _server_IO.Read(buffer, 2, buffer.Length);
                    float temp = System.BitConverter.ToSingle(buffer, 0);
                    Avril_FSD.Library_For_Praise_1_Events.Set_Praise1_Input_mouseDelta_X(temp);
                    temp = System.BitConverter.ToSingle(buffer, 4);
                    Avril_FSD.Library_For_Praise_1_Events.Set_Praise1_Input_mouseDelta_X(temp);
                    break;
            }
        }
        static public void Do_Server_Send(Avril_FSD.ServerAssembly.Framework_Server obj)
        {
            _server_IO.WaitForConnection();
            switch (obj.Get_server().Get_data().Get_output_Instnace().Get_FRONT_outputDoubleBuffer(obj).Get_praiseEventId())
            {
            // USER IMPLEMENTATION - ABCDE
            case 0:

                break;

            case 1:
                byte[] buffer = new byte[38];
                buffer[0] = Avril_FSD.Library_For_Server_Concurrency.Get_PraiseEventId(obj.Get_server().Get_execute().Get_program_ServerConcurrency());
                //buffer[1] = Avril_FSD.Library_For_Server_Concurrency.Get_playerId();
                Avril_FSD.ServerAssembly.Praise_Files.Praise1_Output subset = (Avril_FSD.ServerAssembly.Praise_Files.Praise1_Output)obj.Get_server().Get_data().Get_input_Instnace().Get_BACK_inputDoubleBuffer(obj).Get_praiseInputBuffer_Subset();
                byte[] byteArray = BitConverter.GetBytes(subset.Get_fowards().X);
                for (ushort index = 2; index < 6; index++)
                {
                    buffer[index] = byteArray[index];
                }
                byteArray = BitConverter.GetBytes(subset.Get_fowards().Y);
                for (ushort index = 6; index < 10; index++)
                {
                    buffer[index] = byteArray[index];
                }
                byteArray = BitConverter.GetBytes(subset.Get_fowards().Z);
                for (ushort index = 10; index < 14; index++)
                {
                    buffer[index] = byteArray[index];
                }
                byteArray = BitConverter.GetBytes(subset.Get_right().X);
                for (ushort index = 14; index < 18; index++)
                {
                    buffer[index] = byteArray[index];
                }
                byteArray = BitConverter.GetBytes(subset.Get_right().Y);
                for (ushort index = 18; index < 22; index++)
                {
                    buffer[index] = byteArray[index];
                }
                byteArray = BitConverter.GetBytes(subset.Get_right().Z);
                for (ushort index = 22; index < 26; index++)
                {
                    buffer[index] = byteArray[index];
                }
                byteArray = BitConverter.GetBytes(subset.Get_up().X);
                for (ushort index = 26; index < 30; index++)
                {
                    buffer[index] = byteArray[index];
                }
                byteArray = BitConverter.GetBytes(subset.Get_up().Y);
                for (ushort index = 30; index < 34; index++)
                {
                    buffer[index] = byteArray[index];
                }
                byteArray = BitConverter.GetBytes(subset.Get_up().Z);
                for (ushort index = 34; index < 38; index++)
                {
                    buffer[index] = byteArray[index];
                }
                _server_IO.Write(buffer, 0, buffer.Length);
                break;
            }
        }
    }
}
