using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avril_FSD.ServerAssembly.Praise_Files
{
    public class Praise0_Algorithm
    {
        public Praise0_Algorithm() 
        { 
        
        }
        public void Do_Praise(Avril_FSD.ServerAssembly.Praise_Files.Praise0_Input in_SubSet, Avril_FSD.ServerAssembly.Praise_Files.Praise0_Output out_SubSet)
        {
            out_SubSet.SetFlag_IsPingActive(in_SubSet.GetFlag_IsPingActive());
        }
    }
}
