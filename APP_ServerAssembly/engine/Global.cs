namespace Avril_FSD.ServerAssembly
{
    public class Global
    {
        private int _numberOfCores;
        private byte _numberOfPraises;

        public Global() 
        {
            Set_numberOfCores(4);//number of app shell IO cored threads
            Set_numberOfPraises(2);//Number of Praises
        }

        public int Get_numberOfCores()
        {
            return _numberOfCores;
        }
        public byte Get_numberOfPraises()
        {
            return _numberOfPraises;
        }
        private void Set_numberOfCores(int numberOfCores)
        {
            _numberOfCores = numberOfCores;
        }
        private void Set_numberOfPraises(byte numberOfCores)
        {
            _numberOfPraises = numberOfCores;
        }
    }
}
