
namespace Avril_FSD.ClientAssembly
{
    public class Concurrent
    {
        static private byte _coreId;
        static private Avril_FSD.ClientAssembly.Concurrent_Control _concurrent_Control;
        static private Object _algorithm_Subset;
        public Concurrent() 
        {
            _coreId = 255;
            _concurrent_Control = null;
            _algorithm_Subset = null;
        } 
        public void Initialise_Control()
        {
            _concurrent_Control = new Avril_FSD.ClientAssembly.Concurrent_Control();
            while (_concurrent_Control == null) { /* Wait while is created */ }
        }

        public Object Get_algorithm_Subset()
        {
            return _algorithm_Subset;
        }
        private byte Get_coreId()
        {
            return _coreId;
        }
        public Avril_FSD.ClientAssembly.Concurrent_Control Get_concurrent_Control()
        {
            return _concurrent_Control;
        }

        public void Set_Algorithm_Subset(Avril_FSD.ClientAssembly.Praise_Files.Praise0_Algorithm value)
        {
            _algorithm_Subset = (Object)value;
        }
        public void Set_Algorithm_Subset(Avril_FSD.ClientAssembly.Praise_Files.Praise1_Algorithm value)
        {
            _algorithm_Subset = (Object)value;
        }
        public void Set_Algorithm_Subset(Avril_FSD.ClientAssembly.Praise_Files.Praise2_Algorithm value)
        {
            _algorithm_Subset = (Object)value;
        }
        public void Set_coreId(byte value)
        {
            _coreId = value;
        }
        public void Thread_Concurrent()
        {
            Avril_FSD.ClientAssembly.Framework_Client obj = Avril_FSD.ClientAssembly.Program.Get_framework_Client();
            bool done_once = true;
            while (obj.Get_client().Get_execute().Get_execute_Control().Get_flag_ThreadInitialised(Get_coreId()) == true)
            {
                if (done_once == true)
                {
                    obj.Get_client().Get_execute().Get_execute_Control().Set_flag_ThreadInitialised(Get_coreId(), false);
                    done_once = false;
                }
            }
            System.Console.WriteLine("Thread Initalised => Thread_Concurrent()");//TestBench
            while (obj.Get_client().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == true)
            {

            }
            System.Console.WriteLine("Thread Starting => Thread_Concurrent()");//TestBench
            while (obj.Get_client().Get_execute().Get_execute_Control().Get_flag_isInitialised_ClientApp() == false)
            {
                if (obj.Get_client().Get_data().Get_data_Control().Get_flag_IsLoaded_Stack_OutputRecieve())
                {
                    if (obj.Get_client().Get_data().Get_data_Control().Get_flag_isNewInputDataReady())
                    {
                        Avril_FSD.Library_For_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.Write_Start(obj.Get_client().Get_execute().Get_program_WriteQue_C_OR(), Get_coreId());
                        obj.Get_client().Get_data().Get_output_Instnace().Get_buffer_Output_Recieve_Reference_ForCore((byte)(Get_coreId() - 3)).Get_output_Control().Select_Set_Output_Subset(obj, (byte)(Get_coreId() - 3), obj.Get_client().Get_data().Get_output_Instnace().Get_buffer_Output_Recieve_Reference_ForCore((byte)(Get_coreId() - 3)).Get_praiseEventId());
                        obj.Get_client().Get_algorithms().Get_concurrent(3).Get_concurrent_Control().SelectSet_Algorithm_Subset(obj, obj.Get_client().Get_data().Get_output_Instnace().Get_FRONT_outputDoubleBuffer(obj).Get_praiseEventId(), Get_coreId());
                        obj.Get_client().Get_data().Get_data_Control().Pop_Stack_OutputRecieve(obj.Get_client().Get_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj), obj.Get_client().Get_data().Get_output_Instnace().Get_stack_Client_OutputRecieves());
                        obj.Get_client().Get_data().Flip_OutBufferToWrite();
                        obj.Get_client().Get_data().Get_data_Control().Do_Store_PraiseOutputRecieve_To_GameInstanceData(obj, obj.Get_client().Get_data().Get_output_Instnace().Get_stack_Client_OutputRecieves().ElementAt(1));
                        Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT.Thread_End(obj.Get_client().Get_execute().Get_program_ConcurrentQue_C(), (byte)(Get_coreId() - 3));
                        if (obj.Get_client().Get_data().Get_data_Control().Get_flag_IsLoaded_Stack_OutputRecieve())
                        {
                            if(Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT.Get_State_LaunchBit(obj.Get_client().Get_execute().Get_program_ConcurrentQue_C()))
                            {
                                Avril_FSD.Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT.Request_Wait_Launch(obj.Get_client().Get_execute().Get_program_ConcurrentQue_C(), (byte)(Get_coreId()-3));
                            }
                        }
                        Avril_FSD.Library_For_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.Write_End(obj.Get_client().Get_execute().Get_program_WriteQue_C_OR(), Get_coreId());
                    
                    }
                }
            }
        }
    }
}
