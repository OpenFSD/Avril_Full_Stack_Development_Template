namespace Avril_FSD.ServerAssembly
{
    public class Algorithms
    {
        private Avril_FSD.ServerAssembly.IO_Listen_Respond _io_ListenRespond;
        private Avril_FSD.ServerAssembly.Praise_Files.User_Alg _user_Alg;

        public Algorithms(int numberOfCores) 
        {
            Set_user_Alg(new Praise_Files.User_Alg());
            while (Get_user_Alg() == null) { }
            System.Console.WriteLine("Avril_FSD.ServerAssembly: Algorithms");//TEST
        }

        public void Initialise(int numberOfCores)
        {
            Set_io_ListenRespond(new Avril_FSD.ServerAssembly.IO_Listen_Respond());
            while (Get_io_ListenRespond() == null) { }
            Get_io_ListenRespond().InitialiseControl();
        }

        public Avril_FSD.ServerAssembly.IO_Listen_Respond Get_io_ListenRespond()
        {
            return _io_ListenRespond;
        }

        public Praise_Files.User_Alg Get_user_Alg()
        {
            return _user_Alg;
        }

        private void Set_io_ListenRespond(Avril_FSD.ServerAssembly.IO_Listen_Respond value)
        {
            _io_ListenRespond = value;
        }
        private void Set_user_Alg(Praise_Files.User_Alg value)
        {
            _user_Alg = value;
        }
    }
}
