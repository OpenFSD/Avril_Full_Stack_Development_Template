
namespace Avril_FSD.ServerAssembly.Inputs
{
    public class Input_Instance
    {
        private Avril_FSD.ServerAssembly.Inputs.Input_Instance_Control _inputInstance_Control;
        private Avril_FSD.ServerAssembly.Inputs.Input _empty_InputBuffer;

        private Avril_FSD.ServerAssembly.Inputs.Input[] _inputDoubleBuffer;

        public Input_Instance() 
        {
            Set_inputInstance_Control(new Avril_FSD.ServerAssembly.Inputs.Input_Instance_Control());
            while (Get_inputInstance_Control() == null) { }

            Set_empty_InputBuffer(new Avril_FSD.ServerAssembly.Inputs.Input());
            while (Get_empty_InputBuffer() == null) { }
            Get_empty_InputBuffer().InitialiseControl();

            _inputDoubleBuffer = new Avril_FSD.ServerAssembly.Inputs.Input[2];
            for (byte index = 0; index < 2; index++)
            {
                _inputDoubleBuffer[index] = Get_empty_InputBuffer();
                while (_inputDoubleBuffer[index] == null) { }
            }
        }

        private UInt16 BoolToInt16(bool value)
        {
            UInt16 temp = new UInt16();
            if (value)
            {
                temp = (UInt16)1;
            }
            else if (!value)
            {
                temp = (UInt16)0;
            }
            return temp;
        }

        public Avril_FSD.ServerAssembly.Inputs.Input Get_FRONT_inputDoubleBuffer(Avril_FSD.ServerAssembly.Framework_Server obj)
        {
            return _inputDoubleBuffer[BoolToInt16(obj.Get_server().Get_data().Get_state_Buffer_Input_ToWrite())];
        }
        public Avril_FSD.ServerAssembly.Inputs.Input Get_BACK_inputDoubleBuffer(Avril_FSD.ServerAssembly.Framework_Server obj)
        {
            return _inputDoubleBuffer[BoolToInt16(!obj.Get_server().Get_data().Get_state_Buffer_Input_ToWrite())];
        }

        public Avril_FSD.ServerAssembly.Inputs.Input Get_empty_InputBuffer()
        {
            return _empty_InputBuffer;
        }

        public Avril_FSD.ServerAssembly.Inputs.Input_Instance_Control Get_inputInstance_Control()
        {
            return _inputInstance_Control;
        }

        public void Set_inputDoubleBuffer(Avril_FSD.ServerAssembly.Framework_Server obj, Avril_FSD.ServerAssembly.Inputs.Input value)
        {
            _inputDoubleBuffer[BoolToInt16(obj.Get_server().Get_data().Get_state_Buffer_Input_ToWrite())] = value;
        }

        public void Set_empty_InputBuffer(Avril_FSD.ServerAssembly.Inputs.Input input)
        {
            _empty_InputBuffer = input;
        }

        public void Set_inputInstance_Control(Avril_FSD.ServerAssembly.Inputs.Input_Instance_Control input_Instance_Control)
        {
            _inputInstance_Control = input_Instance_Control;
        }
    }
}
