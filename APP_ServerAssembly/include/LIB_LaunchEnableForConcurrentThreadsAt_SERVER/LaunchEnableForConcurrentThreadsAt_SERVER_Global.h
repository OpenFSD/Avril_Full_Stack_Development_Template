#pragma once


namespace Avril_FSD
{
    class LaunchEnableForConcurrentThreadsAt_SERVER_Global
    {
    public:
        LaunchEnableForConcurrentThreadsAt_SERVER_Global();
        ~LaunchEnableForConcurrentThreadsAt_SERVER_Global();
        bool Get_flag_core_ACTIVE();
        bool Get_flag_core_IDLE();
        unsigned char Get_number_Implemented_Cores();

    private:
        static void Set_flag_core_ACTIVE(bool value);
        static void Set_flag_core_IDLE(bool value);
        static void Set_number_Implemented_Cores(__int8 coreId);
    };
}
