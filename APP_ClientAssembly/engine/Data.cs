namespace Avril_FSD.ClientAssembly
{
    public class Data
    {
        private Avril_FSD.ClientAssembly.Data_Control _data_Control;
        private Avril_FSD.ClientAssembly.Game_Instance _gameInstance;
        private ClientAssembly.GameInstance.Settings _settings;
        private Avril_FSD.ClientAssembly.Inputs.Input_Instance _input_Instnace;
        private Avril_FSD.ClientAssembly.Outputs.Output_Instance _output_Instnace;
        private Avril_FSD.ClientAssembly.Praise_Files.User_I _user_I;
        private Avril_FSD.ClientAssembly.Praise_Files.User_O _user_O;
        private bool _state_Buffer_Input_ToWrite;
        private bool _state_Buffer_Output_ToWrite;

        public Data()
        {
            Set_data_Control(null);

            Set_gameInstance(new Avril_FSD.ClientAssembly.Game_Instance());
            while (Get_gameInstance() == null) { }

            Set_settings(new Avril_FSD.ClientAssembly.GameInstance.Settings());
            while (Get_settings() == null) { }

            Set_input_Instnace(new Avril_FSD.ClientAssembly.Inputs.Input_Instance());
            while (Get_input_Instnace() == null) { }

            Set_output_Instnace(new Avril_FSD.ClientAssembly.Outputs.Output_Instance());
            while (Get_output_Instnace() == null) { }

            Set_user_I(new Avril_FSD.ClientAssembly.Praise_Files.User_I());
            while (Get_user_I() == null) { }

            Set_user_O(new Avril_FSD.ClientAssembly.Praise_Files.User_O());
            while (Get_user_O() == null) { }

            Set_state_Buffer_Input_ToWrite(true);
            Set_state_Buffer_Output_ToWrite(false);

            System.Console.WriteLine("Avril_FSD.ClientAssembly: Data");
        }

        public void InitialiseControl()
        {
            Set_data_Control(new Avril_FSD.ClientAssembly.Data_Control());
            while (Get_data_Control() == null) { }
        }

        public void Flip_InBufferToWrite()
        {
            Set_state_Buffer_Input_ToWrite(!Get_state_Buffer_Input_ToWrite());
        }
        public void Flip_OutBufferToWrite()
        {
            Set_state_Buffer_Output_ToWrite(!Get_state_Buffer_Output_ToWrite());
        }

        public Avril_FSD.ClientAssembly.Data_Control Get_data_Control()
        {
            return _data_Control;
        }

        public Avril_FSD.ClientAssembly.Game_Instance Get_gameInstance()
        {
            return _gameInstance;
        }

        public Avril_FSD.ClientAssembly.Inputs.Input_Instance Get_input_Instnace()
        {
            return _input_Instnace;
        }
        
        public Avril_FSD.ClientAssembly.Outputs.Output_Instance Get_output_Instnace()
        {
            return _output_Instnace;
        }

        public bool Get_state_Buffer_Input_ToWrite()
        {
            return _state_Buffer_Input_ToWrite;
        }
        public bool Get_state_Buffer_Output_ToWrite()
        {
            return _state_Buffer_Output_ToWrite;
        }

        public ClientAssembly.GameInstance.Settings Get_settings()
        {
            return _settings;
        }

        public Avril_FSD.ClientAssembly.Praise_Files.User_I Get_user_I()
        {
            return _user_I;
        }
        public Avril_FSD.ClientAssembly.Praise_Files.User_O Get_user_O()
        {
            return _user_O;
        }
        private void Set_data_Control(Avril_FSD.ClientAssembly.Data_Control data_Control)
        {
            _data_Control = data_Control;
        }

        private void Set_gameInstance(Avril_FSD.ClientAssembly.Game_Instance game_Instance)
        {
            _gameInstance = game_Instance;
        }

        private void Set_input_Instnace(Avril_FSD.ClientAssembly.Inputs.Input_Instance input_Instance)
        {
            _input_Instnace = input_Instance;
        }
        private void Set_state_Buffer_Input_ToWrite(bool state_Buffer_Input_ToWrite)
        {
            _state_Buffer_Input_ToWrite = state_Buffer_Input_ToWrite;
        }
        private void Set_state_Buffer_Output_ToWrite(bool state_Buffer_Output_ToWrite)
        {
            _state_Buffer_Output_ToWrite = state_Buffer_Output_ToWrite;
        }


        private void Set_output_Instnace(Avril_FSD.ClientAssembly.Outputs.Output_Instance output_Instance)
        {
            _output_Instnace = output_Instance;
        }
        private void Set_settings(ClientAssembly.GameInstance.Settings settings)
        {
            _settings = settings;
        }

        private void Set_user_I(Avril_FSD.ClientAssembly.Praise_Files.User_I user_I)
        {
            _user_I = user_I;
        }
        private void Set_user_O(Avril_FSD.ClientAssembly.Praise_Files.User_O user_O)
        {
            _user_O = user_O;
        }
    }
}
