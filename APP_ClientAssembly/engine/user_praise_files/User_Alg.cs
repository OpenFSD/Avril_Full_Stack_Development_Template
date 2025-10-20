
namespace Avril_FSD.ClientAssembly.Praise_Files
{
    public class User_Alg
    {
        private Praise0_Algorithm _praise0_Algorithm = null;
        private Praise1_Algorithm _praise1_Algorithm = null;

        public User_Alg() 
        {
            Set_praise0_Algorithm(new Avril_FSD.ClientAssembly.Praise_Files.Praise0_Algorithm());
            while (Get_praise0_Algorithm() == null) { /* Wait while is created */ }

            Set_praise1_Algorithm(new Avril_FSD.ClientAssembly.Praise_Files.Praise1_Algorithm());
            while (Get_praise1_Algorithm() == null) { /* Wait while is created */ }
        }

        public Praise0_Algorithm Get_praise0_Algorithm()
        {
            return _praise0_Algorithm;
        }

        public Praise1_Algorithm Get_praise1_Algorithm()
        {
            return _praise1_Algorithm;
        }

        private void Set_praise0_Algorithm(Praise0_Algorithm praise0_Algorithm)
        {
            _praise0_Algorithm = praise0_Algorithm;
        }
        private void Set_praise1_Algorithm(Praise1_Algorithm praise1_Algorithm)
        {
            _praise1_Algorithm = praise1_Algorithm;
        }
    }
}
