using System;

namespace Avril_FSD.ServerAssembly.Inputs
{
    public class Input
    {
        private Avril_FSD.ServerAssembly.Inputs.Input_Control _input_Control;
        private Object _praiseInputBuffer_Subset;
        private byte _in_praiseEventId;
        private byte _in_playerId;

        public Input()
        {
            Set_input_Control(null);
            Set_praiseInputBuffer_Subset(null);
            Set_praiseEventId(0);
            System.Console.WriteLine("Avril_FSD.ServerAssembly: Input");
        }

        public void InitialiseControl() 
        {
            Set_input_Control(new Avril_FSD.ServerAssembly.Inputs.Input_Control());
            while (Get_input_Control() == null) { }
        }
        public Avril_FSD.ServerAssembly.Inputs.Input_Control Get_input_Control()
        {
            return _input_Control;
        }
        public Object Get_praiseInputBuffer_Subset()
        {
            return _praiseInputBuffer_Subset;
        }
        public byte Get_praiseEventId()
        {
            return _in_praiseEventId;
        }
        public byte Get_in_playerId()
        {
            return _in_playerId;
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
            _in_praiseEventId = value;
        }
        public void Set_in_playerId(byte value)
        {
            _in_playerId = value;
        }
    }
}