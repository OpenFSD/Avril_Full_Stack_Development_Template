#pragma once

namespace Avril_FSD
{
    class Execute
    {
    public:
        Execute();
        virtual ~Execute();
        void Initialise(class Framework_Server* obj);
        void Initialise_Control(__int8 number_Implemented_Cores);
        void Initialise_Libraries();
        void Initialise_Threads(class Framework_Server* obj);

        class Execute_Control* Get_Control_Of_Execute();
        class LaunchEnableForConcurrentThreadsAt_SERVER_Framework* Get_Program_ConcurrentQue_Server();
        class WriteEnableForThreadsAt_SERVERINPUTACTION_Framework* Get_Program_WriteEnable_ServerInputAction();
        class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* Get_Program_WriteEnable_ServerOutputRecieve();

    private:
        static void Set_Control_Of_Execute(class Execute_Control* execute_Control);
    };
}