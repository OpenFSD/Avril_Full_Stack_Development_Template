#pragma once

namespace Avril_FSD
{
    class WriteEnableForThreadsAt_SERVERINPUTACTION_Global
    {
    public:
        WriteEnableForThreadsAt_SERVERINPUTACTION_Global();
        ~WriteEnableForThreadsAt_SERVERINPUTACTION_Global();
        unsigned char Get_NumCores();
        std::vector<bool> Get_flag_write_IDLE();
        std::vector<bool> Get_flag_write_WAIT();
        std::vector<bool> Get_flag_write_WRITE();
    };
}

