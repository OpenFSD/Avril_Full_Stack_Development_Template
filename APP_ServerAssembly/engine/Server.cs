namespace Avril_FSD.ServerAssembly
{
    public class Server
    {
        private Algorithms _algorithms;
        private Data _data;
        private Execute _execute;
        private Global _global;

        public Server()
        {
            Set_global(new Global());
            while (Get_global() == null) { }

            Set_algorithms(new Algorithms(Get_global().Get_numberOfCores()));
            while (Get_algorithms() == null) { }

            Set_data(new Data());
            while (Get_data() == null) { }
            Get_data().InitialiseControl();

            Set_execute(new Execute(Get_global().Get_numberOfCores()));
            while (Get_execute() == null) { }
            Get_execute().Initialise_Control(Get_global().Get_numberOfCores(), Get_global());

        }

        public Algorithms Get_algorithms()
        {
            return _algorithms;
        }
        public Data Get_data()
        {
            return _data;
        }
        public Execute Get_execute()
        {
            return _execute;
        }

        public Global Get_global()
        {
            return _global;
        }
        private void Set_algorithms(Algorithms value)
        {
            _algorithms = value;
        }
        private void Set_data(Data value)
        {
            _data = value;
        }
        private void Set_execute(Execute value)
        {
            _execute = value;
        }
        private void Set_global(Global value)
        {
            _global = value;
        }
    }
}