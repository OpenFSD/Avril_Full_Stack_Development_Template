namespace Avril_FSD.ClientAssembly
{
    public class Client
    {
        private Avril_FSD.ClientAssembly.Algorithms _algorithms;
        private Avril_FSD.ClientAssembly.Data _data;
        private Avril_FSD.ClientAssembly.Execute _execute;
        private Avril_FSD.ClientAssembly.Global _global;

        public Client() 
        {
            Set_global(new Avril_FSD.ClientAssembly.Global());
            while (Get_global() == null) { }

            Set_algorithms(new Avril_FSD.ClientAssembly.Algorithms(Get_global().Get_numberOfCores()));
            while (Get_algorithms() == null) { }

            Set_data(new Avril_FSD.ClientAssembly.Data());
            while (Get_data() == null) { }
            Get_data().InitialiseControl();

            Set_execute(new Avril_FSD.ClientAssembly.Execute(Get_global().Get_numberOfCores()));
            while (Get_execute() == null) { }
            Get_execute().Initialise_Control(Get_global().Get_numberOfCores(), Get_global());

        }

        public Avril_FSD.ClientAssembly.Algorithms Get_algorithms()
        {
            return _algorithms;
        }
        public Avril_FSD.ClientAssembly.Data Get_data()
        {
            return _data;
        }
        public Avril_FSD.ClientAssembly.Execute Get_execute()
        {
            return _execute;
        }

        public Avril_FSD.ClientAssembly.Global Get_global()
        {
            return _global;
        }
        private void Set_algorithms(Avril_FSD.ClientAssembly.Algorithms value)
        {
            _algorithms = value;
        }
        private void Set_data(Avril_FSD.ClientAssembly.Data value)
        {
            _data = value;
        }
        private void Set_execute(Avril_FSD.ClientAssembly.Execute value)
        {
            _execute = value;
        }
        private void Set_global(Avril_FSD.ClientAssembly.Global value)
        {
            _global = value;
        }
    }
}