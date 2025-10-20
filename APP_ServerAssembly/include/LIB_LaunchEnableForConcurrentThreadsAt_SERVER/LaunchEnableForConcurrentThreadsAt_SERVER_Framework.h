#pragma once

namespace Avril_FSD
{
    class LaunchEnableForConcurrentThreadsAt_SERVER_Framework
    {
    public:
        LaunchEnableForConcurrentThreadsAt_SERVER_Framework();
        virtual ~LaunchEnableForConcurrentThreadsAt_SERVER_Framework();
        class LaunchEnableForConcurrentThreadsAt_SERVER* Get_LaunchEnableForConcurrentThread();

    private:
        static void Create_LaunchEnableForConcurrentThreadsAt();
        static class LaunchEnableForConcurrentThreadsAt_SERVER* Get__LaunchEnableForConcurrentThreadsAt();
        static void Set_LaunchEnableForConcurrentThreadsAt(class LaunchEnableForConcurrentThreadsAt_SERVER* concurrentQue);
    };
}