#pragma once

namespace Avril_FSD
{
    class Concurrent
    {
    public:
        Concurrent();
        virtual ~Concurrent();
        void Initialise_Control();
        class Concurrent_Control* Get_Concurrent_Control();

        static void Thread_Concurrency(class Framework_Server* obj, __int8 concurrent_coreId);
        void Do_Concurrent_Algorithm_For_PraiseEventId(class Framework_Server* obj, char playerId, __int8 ptr_praiseEventId, class Object* ptr_Algorithm_Subset, class Object* ptr_Input_Subset, class Object* ptr_Output_Subset);

        class Object* Get_Algorithm_Subset();
        
        void Set_Algorithm_Subset(class Praise0_Algorithm* praise0_algorithm);
        void Set_Algorithm_Subset(class Praise1_Algorithm* praise1_algorithm);
        void Set_Algorithm_Subset(class Praise2_Algorithm* praise2_algorithm);

    protected:

    private:
        static void Set_Concurrent_Control(class Concurrent_Control* concurrent_control);
    };
}