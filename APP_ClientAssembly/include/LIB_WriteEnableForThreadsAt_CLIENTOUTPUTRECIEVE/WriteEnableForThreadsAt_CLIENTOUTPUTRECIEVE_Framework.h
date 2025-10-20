#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Framework
    {
    public:
        WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Framework();
        virtual ~WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Framework();
        class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE* Get_writeEnable();

    private:
        static void Set_writeEnable(class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE* writeEnable);
    };
}