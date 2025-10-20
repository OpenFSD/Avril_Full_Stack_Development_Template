#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Global
    {
    public:
        WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Global();
        ~WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Global();
        unsigned char Get_NumCores();
        std::vector<bool> Get_flag_write_IDLE();
        std::vector<bool> Get_flag_write_WAIT();
        std::vector<bool> Get_flag_write_WRITE();
    };
}

