#pragma once

namespace Avril_FSD
{
    class Server
    {
    public:
        Server();
        virtual ~Server();
        class Algorithms* Get_Algorithms();
        class Data* Get_Data();
        class Execute* Get_Execute();
        class Global* Get_Global();

    private:
        static void Set_Algorithms(class Algorithms* algorithms);
        static void Set_Data(class Data* data);
        static void Set_Execute(class Execute* execute);
        static void Set_Global(class Global* global);
    };
}