#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_CLIENTINPUTACTION
    {
    public:
        WriteEnableForThreadsAt_CLIENTINPUTACTION();
        virtual ~WriteEnableForThreadsAt_CLIENTINPUTACTION();
        void Initialise_Control();

        void Write_End(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj, unsigned char coreId);
        void Write_Start(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj, unsigned char coreId);

        class WriteEnableForThreadsAt_CLIENTINPUTACTION_Global* Get_global();
        class WriteEnableForThreadsAt_CLIENTINPUTACTION_Control* Get_writeEnable_Control();

    private:
        static void Set_global(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Global* global);
        static void Set_writeEnable_Control(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Control* writeEnableControl);
    };
}
