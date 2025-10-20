#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_SERVERINPUTACTION
    {
    public:
        WriteEnableForThreadsAt_SERVERINPUTACTION();
        virtual ~WriteEnableForThreadsAt_SERVERINPUTACTION();
        void Initialise_Control();

        void Write_End(class WriteEnableForThreadsAt_SERVERINPUTACTION_Framework* obj, unsigned char coreId);
        void Write_Start(class WriteEnableForThreadsAt_SERVERINPUTACTION_Framework* obj, unsigned char coreId);

        class WriteEnableForThreadsAt_SERVERINPUTACTION_Global* Get_global();
        class WriteEnableForThreadsAt_SERVERINPUTACTION_Control* Get_writeEnable_Control();

    private:
        static void Set_global(class WriteEnableForThreadsAt_SERVERINPUTACTION_Global* global);
        static void Set_writeEnable_Control(class WriteEnableForThreadsAt_SERVERINPUTACTION_Control* writeEnableControl);
    };
}
