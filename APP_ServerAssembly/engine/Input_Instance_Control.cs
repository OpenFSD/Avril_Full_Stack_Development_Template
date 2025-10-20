
namespace Avril_FSD.ServerAssembly.Inputs
{
    public class Input_Instance_Control
    {
        private bool[] _isSelected_PraiseEventId = { false, false };

        public Input_Instance_Control() 
        {
            _isSelected_PraiseEventId = new bool[2] { false, false };
        }

        public bool Get_IsSelected_PraiseEventId(int index)
        {
            return _isSelected_PraiseEventId[index];
        }

        public int GetLength_IsSelected_PraiseEventId()
        {
            return _isSelected_PraiseEventId.Length;
        }

        public void SetIsSelected_PraiseEventId(int index, bool value)
        {
            _isSelected_PraiseEventId[index] = value;
        }
    }
}
