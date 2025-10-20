
using OpenTK;

namespace Avril_FSD.ServerAssembly.Praise_Files
{
    public class Praise1_Output
    {
        private Vector3 _fowards;
        private Vector3 _right;
        private Vector3 _up;

        public Praise1_Output() 
        { 
        
        }

        public Vector3 Get_fowards()
        {
            return _fowards;
        }
        public Vector3 Get_right()
        {
            return _right;
        }
        public Vector3 Get_up()
        {
            return _up;
        }

        public void Set_fowards(Vector3 value)
        {
            _fowards = value;
        }
        public void Set_right(Vector3 value)
        {
            _right = value;
        }
        public void Set_up(Vector3 value)
        {
            _up = value;
        }
    }
}
