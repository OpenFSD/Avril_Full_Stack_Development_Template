#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE
    {
    public:
        WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE();
        virtual ~WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE();
        void Initialise_Control();

        void Write_End(class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Framework* obj, unsigned char coreId);
        void Write_Start(class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Framework* obj, unsigned char coreId);

        class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Global* Get_global();
        class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Control* Get_writeEnable_Control();

    private:
        static void Set_global(class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Global* global);
        static void Set_writeEnable_Control(class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Control* writeEnableControl);
    };
}
