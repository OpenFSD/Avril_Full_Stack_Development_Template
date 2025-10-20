#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE
    {
    public:
        WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE();
        virtual ~WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE();
        void Initialise_Control();

        void Write_End(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* obj, unsigned char coreId);
        void Write_Start(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* obj, unsigned char coreId);

        class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Global* Get_global();
        class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Control* Get_writeEnable_Control();

    private:
        static void Set_global(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Global* global);
        static void Set_writeEnable_Control(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Control* writeEnableControl);
    };
}
