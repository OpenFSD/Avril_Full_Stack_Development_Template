#pragma once

namespace Avril_FSD
{
    class GameInstance
    {
    public:
        GameInstance();
        virtual ~GameInstance();

        class Player* Get_player(__int8 playerId);
        class Settings* Get_settings();

    protected:

    private:
        static void Set_player(class Player* player);
        static void Set_settings(class Settings* settings);
    };
}