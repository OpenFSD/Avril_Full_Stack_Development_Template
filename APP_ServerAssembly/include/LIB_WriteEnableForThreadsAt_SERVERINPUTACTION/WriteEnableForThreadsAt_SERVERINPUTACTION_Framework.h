#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_SERVERINPUTACTION_Framework
    {
    public:
        WriteEnableForThreadsAt_SERVERINPUTACTION_Framework();
        virtual ~WriteEnableForThreadsAt_SERVERINPUTACTION_Framework();
        class WriteEnableForThreadsAt_SERVERINPUTACTION* Get_writeEnable();

    private:
        static void Set_writeEnable(class WriteEnableForThreadsAt_SERVERINPUTACTION* writeEnable);
    };
}