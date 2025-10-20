#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework
    {
    public:
        WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework();
        virtual ~WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework();
        class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE* Get_writeEnable();

    private:
        static void Set_writeEnable(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE* writeEnable);
    };
}