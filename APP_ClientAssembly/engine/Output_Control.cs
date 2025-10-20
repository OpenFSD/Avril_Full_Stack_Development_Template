
namespace Avril_FSD.ClientAssembly.Outputs
{
    public class Output_Control
    {
        public Output_Control() 
        {

        }

        public void Select_Set_Output_Subset(Avril_FSD.ClientAssembly.Framework_Client obj, byte concurrent_coreId, byte praiseEventId)
        {
            switch (praiseEventId)
            {
                case 0:
                    obj.Get_client().Get_data().Get_output_Instnace().Get_buffer_Output_Recieve_Reference_ForCore(concurrent_coreId).Set_praiseOutputBuffer_Subset(obj.Get_client().Get_data().Get_user_O().GetPraise0_Outnput());
                    break;

                case 1:
                    obj.Get_client().Get_data().Get_output_Instnace().Get_buffer_Output_Recieve_Reference_ForCore(concurrent_coreId).Set_praiseOutputBuffer_Subset(obj.Get_client().Get_data().Get_user_O().GetPraise1_Output());
                    break;

                case 2:
                    
                    break;

            }
        }
    }
}
