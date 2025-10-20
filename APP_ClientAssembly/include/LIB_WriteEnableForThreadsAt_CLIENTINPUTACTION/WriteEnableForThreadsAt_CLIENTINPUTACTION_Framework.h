#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework
    {
    public:
        WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework();
        virtual ~WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework();
        class WriteEnableForThreadsAt_CLIENTINPUTACTION* Get_writeEnable();

    private:
        static void Set_writeEnable(class WriteEnableForThreadsAt_CLIENTINPUTACTION* writeEnable);
    };
}