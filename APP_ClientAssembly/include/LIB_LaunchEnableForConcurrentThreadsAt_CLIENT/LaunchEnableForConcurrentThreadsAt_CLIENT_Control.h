#pragma once


namespace Avril_FSD
{
    class LaunchEnableForConcurrentThreadsAt_CLIENT_Control
    {
    public:
        LaunchEnableForConcurrentThreadsAt_CLIENT_Control(class LaunchEnableForConcurrentThreadsAt_CLIENT_Global* global, unsigned char number_Implemented_Cores);
        virtual ~LaunchEnableForConcurrentThreadsAt_CLIENT_Control();

        void LaunchEnable_Activate(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj);
        void LaunchEnable_Request(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, unsigned char concurrent_CoreId);
        void LaunchEnable_SortQue(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, unsigned char number_Implemented_Cores);
        void LaunchQue_Update(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, unsigned char number_Implemented_Cores);

        unsigned char Get_concurrentCycle_Try_CoreId_Index();
        unsigned char Get_flag_CoreId_Of_CoreToLaunch();
        bool Get_flag_praisingLaunch();
        unsigned char Get_new_concurrentCycle_Try_CoreId_Index();
        bool Get_state_ConcurrentCore(unsigned char concurrent_CoreId);
        unsigned char Get_que_CoreToLaunch(unsigned char index);

        void Set_concurrentCycle_Try_CoreId_Index(unsigned char concurrentCycle_Try_CoreId_Index);
        void Set_flag_praisingLaunch(bool flag_praisingLaunch);
        void Set_new_concurrentCycle_Try_CoreId_Index(unsigned char new_concurrentCycle_Try_CoreId_Index);
        void Set_state_ConcurrentCore(bool state_ConcurrentCore, unsigned char concurrent_CoreId);

    protected:

    private:
        void DynamicStagger(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, unsigned char coreId);
        void LaunchEnable_ShiftQueValues(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, unsigned char concurrent_CoreId_A, unsigned char concurrent_CoreId_B);
        
        int Get_count_LaunchActive_For(unsigned char concurrent_CoreId);
        int Get_count_LaunchIdle_For(unsigned char concurrent_CoreId);
        std::vector<unsigned char>* Get_stack_PriseEventId();
        
        void Set_count_LaunchActive_For(int count_LaunchActive_For, unsigned char concurrent_CoreId);
        void Set_count_LaunchIdle_For(int count_LaunchIdle_For, unsigned char concurrent_CoreId);
        void Set_stack_PriseEventId(std::vector<unsigned char>* stack_PriseEventId);
        void Set_que_CoreToLaunch(unsigned char que_CoreToLaunch, unsigned char index);
    };
}