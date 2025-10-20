using System;

namespace Avril_FSD.ClientAssembly.Inputs
{
    public class Input
    {
        private Avril_FSD.ClientAssembly.Inputs.Input_Control _input_Control;
        private Object _praiseInputBuffer_Subset;
        private byte _praiseEventId;
        private byte _playerId;

        public Input()
        {
            Set_input_Control(null);
            Set_praiseInputBuffer_Subset(null);
            Set_praiseEventId(0);
            System.Console.WriteLine("Avril_FSD.ClientAssembly: Input");
        }

        public void InitialiseControl() 
        {
            Set_input_Control(new Avril_FSD.ClientAssembly.Inputs.Input_Control());
            while (Get_input_Control() == null) { }
        }
        public Avril_FSD.ClientAssembly.Inputs.Input_Control Get_input_Control()
        {
            return _input_Control;
        }
        public Object Get_praiseInputBuffer_Subset()
        {
            return _praiseInputBuffer_Subset;
        }
        public byte Get_praiseEventId()
        {
            return _praiseEventId;
        }
        public byte Get_playerId()
        {
            return _playerId;
        }
        public void Set_input_Control(Input_Control value)
        {
            _input_Control = value;
        }
        public void Set_praiseInputBuffer_Subset(Object value)
        {
            _praiseInputBuffer_Subset = value;
        }
        
        public void Set_praiseEventId(byte value)
        {
            _praiseEventId = value;
        }
        public void Set_playerId(byte value)
        {
            _playerId = value;
        }
    }
}