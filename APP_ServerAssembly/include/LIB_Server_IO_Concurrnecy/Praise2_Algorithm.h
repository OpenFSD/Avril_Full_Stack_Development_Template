#pragma once

namespace Avril_FSD
{
    class Praise2_Algorithm
    {
    public:
        Praise2_Algorithm();
        virtual ~Praise2_Algorithm();
        void Do_Praise(class Praise2_Input* ptr_In_SubSet, class Praise2_Output* ptr_Out_SubSet);
    };
}