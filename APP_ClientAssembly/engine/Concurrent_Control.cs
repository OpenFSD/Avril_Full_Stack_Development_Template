using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avril_FSD.ClientAssembly
{
    public class Concurrent_Control
    {
        public Concurrent_Control()
        {

        }

        public void SelectSet_Algorithm_Subset(Avril_FSD.ClientAssembly.Framework_Client obj, byte praiseEventId, byte concurrentCoreId)
        {
            switch (praiseEventId)
            {
            case 0:
                obj.Get_client().Get_algorithms().Get_concurrent(concurrentCoreId).Set_Algorithm_Subset(obj.Get_client().Get_algorithms().Get_user_Alg().Get_praise0_Algorithm());
                break;

            case 1:
                obj.Get_client().Get_algorithms().Get_concurrent(concurrentCoreId).Set_Algorithm_Subset(obj.Get_client().Get_algorithms().Get_user_Alg().Get_praise1_Algorithm());
                break;

            }
        }
    }
}
