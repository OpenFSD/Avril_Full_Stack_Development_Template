using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avril_FSD.ClientAssembly.Praise_Files
{
    public class User_I
    {
        static private Avril_FSD.ClientAssembly.Praise_Files.Praise0_Input praise0_Input;
        static private Avril_FSD.ClientAssembly.Praise_Files.Praise1_Input praise1_Input;
        static private Avril_FSD.ClientAssembly.Praise_Files.Praise2_Input praise2_Input;

        public User_I() 
        {
            praise0_Input = new Avril_FSD.ClientAssembly.Praise_Files.Praise0_Input();
            praise1_Input = new Avril_FSD.ClientAssembly.Praise_Files.Praise1_Input();
            praise2_Input = new Avril_FSD.ClientAssembly.Praise_Files.Praise2_Input();
        }

        public Avril_FSD.ClientAssembly.Praise_Files.Praise0_Input GetPraise0_Input()
        {
            return praise0_Input;
        }
        public Avril_FSD.ClientAssembly.Praise_Files.Praise1_Input GetPraise1_Input()
        {
            return praise1_Input;
        }

        public Avril_FSD.ClientAssembly.Praise_Files.Praise2_Input GetPraise2_Input()
        {
            return praise2_Input;
        }
    }
}
