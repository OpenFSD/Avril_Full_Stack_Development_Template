namespace Avril_FSD.ClientAssembly.Praise_Files
{
    public class Praise1_Input
    {
        private float mouse_X;
        private float mouse_Y;

        public Praise1_Input()
        {
            mouse_X = 0;
            mouse_Y = 0;
        }

        public float Get_Mouse_X() 
        {   
            return mouse_X; 
        }

        public float Get_Mouse_Y()
        {
            return mouse_Y;
        }

        public void Set_Mouse_X(float value) 
        {
            mouse_X = value;
        }
        
        public void Set_Mouse_Y(float value)
        {
            mouse_Y = value;
        }
    }
}
