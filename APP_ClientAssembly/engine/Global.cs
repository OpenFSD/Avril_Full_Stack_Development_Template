namespace Avril_FSD.ClientAssembly
{
    public class Global
    {
        private int _numberOfCores;
        private byte _numberOfPraises;

        public Global() 
        {
            Set_numberOfCores(6);//number of app shell threads.
            Set_numberOfPraises(2);//Number of Praises.
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
