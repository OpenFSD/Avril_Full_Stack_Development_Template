
namespace Avril_FSD.ClientAssembly.Outputs
{
    public class Output_Instance_Control
    {
        private bool[] _isSelected_PraiseEventId = { false, false };

        public Output_Instance_Control()
        {
            _isSelected_PraiseEventId = new bool[2] { false, false };
        }

        public bool Get_isSelected_PraiseEventId(int index)
        {
            return _isSelected_PraiseEventId[index];
        }

        public int Get_isSelected_PraiseEventId()
        {
            return _isSelected_PraiseEventId.Length;
        }

        public void Set_isSelected_PraiseEventId(int index, bool value)
        {
            _isSelected_PraiseEventId[index] = value;
        }
    }
}
