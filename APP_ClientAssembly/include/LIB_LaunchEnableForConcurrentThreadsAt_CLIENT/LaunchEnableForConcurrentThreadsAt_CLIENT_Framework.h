#pragma once

namespace Avril_FSD
{
    class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework
    {
    public:
        LaunchEnableForConcurrentThreadsAt_CLIENT_Framework();
        virtual ~LaunchEnableForConcurrentThreadsAt_CLIENT_Framework();
        class LaunchEnableForConcurrentThreadsAt_CLIENT* Get_LaunchEnableForConcurrentThread();

    private:
        static void Create_LaunchEnableForConcurrentThreadsAt();
        static class LaunchEnableForConcurrentThreadsAt_CLIENT* Get__LaunchEnableForConcurrentThreadsAt();
        static void Set_LaunchEnableForConcurrentThreadsAt(class LaunchEnableForConcurrentThreadsAt_CLIENT* concurrentQue);
    };
}