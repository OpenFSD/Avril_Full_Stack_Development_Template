
namespace Avril_FSD.ServerAssembly.Outputs
{
    public class Output_Control
    {
        public Output_Control() 
        {

        }

        public void SelectSetOutputSubset(Avril_FSD.ServerAssembly.Framework_Server obj, int praiseEventId)
        {
            switch (praiseEventId)
            {
                case 0:
                    obj.Get_server().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj).SetInputBufferSubSet(obj.Get_server().Get_data().Get_user_I().GetPraise0_Input());
                    break;

                case 1:
                    obj.Get_server().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj).SetInputBufferSubSet(obj.Get_server().Get_data().Get_user_I().GetPraise1_Input());
                    break;

                case 2:
                    obj.Get_server().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj).SetInputBufferSubSet(obj.Get_server().Get_data().Get_user_I().GetPraise2_Input());
                    break;

            }
        }
    }
}
