#pragma once

namespace Avril_FSD
{
    class Input
    {
    public:
        Input();
        virtual ~Input();
        void Initialise_Control();

        class Input_Control* Get_Input_Control();
        class Object* Get_InputBuffer_Subset();
        
        __int8 GetPraiseEventId();
        __int8 Get_playerId();

        void Set_in_praiseEventId(__int8 praiseEventId);
        void Set_in_playerId(__int8 praiseEventId);
        void Set_Subset_InputBuffer(class Praise0_Input* value);
        void Set_Subset_InputBuffer(class Praise1_Input* value);
        void Set_Subset_InputBuffer(class Praise2_Input* value);
        
    protected:

    private:
        static void Set_input_Control(class Input_Control* input_Control);
    };
}