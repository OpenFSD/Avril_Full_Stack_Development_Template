#pragma once

namespace Avril_FSD
{
    class LaunchEnableForConcurrentThreadsAt_SERVER
    {
    public:
        LaunchEnableForConcurrentThreadsAt_SERVER();
        virtual ~LaunchEnableForConcurrentThreadsAt_SERVER();
        void Initialise_Control();
        void Thread_Start(class LaunchEnableForConcurrentThreadsAt_SERVER_Framework* obj, unsigned char concurrent_CoreId);
        void Thread_End(class LaunchEnableForConcurrentThreadsAt_SERVER_Framework* obj, unsigned char concurrent_CoreId);

        class LaunchEnableForConcurrentThreadsAt_SERVER_Global* Get_LaunchConcurrency_Global();
        class LaunchEnableForConcurrentThreadsAt_SERVER_Control* Get_Control_Of_LaunchConcurrency();

    private:
        static void Create_LaunchEnableForConcurrentThreadsAt_SERVER_Global();
        static void Create_Control_Of_LaunchConcurrency();

        static class LaunchEnableForConcurrentThreadsAt_SERVER_Global* Get__LaunchConcurrency_Global();
        static class LaunchEnableForConcurrentThreadsAt_SERVER_Control* Get__Control_Of_LaunchConcurrency();

        static void Set_LaunchConcurrency_Global(class LaunchEnableForConcurrentThreadsAt_SERVER_Global* global);
        static void Set_Control_Of_LaunchConcurrency(class LaunchEnableForConcurrentThreadsAt_SERVER_Control* control);
    };
}