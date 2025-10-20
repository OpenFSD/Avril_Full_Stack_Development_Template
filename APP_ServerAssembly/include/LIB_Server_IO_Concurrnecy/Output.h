#pragma once

namespace Avril_FSD
{
    class Output
    {
    public:
        Output();
        virtual ~Output();
        void Initialise_Control();

        class Output_Control* Get_control_Of_Output();
        class Object* Get_praiseOutputBuffer_Subset();
        __int8 Get_out_praiseEventId();
        __int8 Get_out_playerId();

        void Set_praiseEventId(__int8 value);
        void Set_out_playerId(__int8 value);
        void Set_OutputBuffer_Subset(class Praise0_Output* praise0_value);
        void Set_OutputBuffer_Subset(class Praise1_Output* praise0_value);
        void Set_OutputBuffer_Subset(class Praise2_Output* praise0_value);
// user implementation - ABCDE        

    protected:

    private:
        static void Set_control_Of_Output(class Output_Control* output_Control);
    };
}