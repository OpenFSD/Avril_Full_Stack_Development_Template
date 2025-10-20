#pragma once

namespace Avril_FSD
{
    class Input_Control
    {
    public:
        Input_Control();
        virtual ~Input_Control();
        
        void SelectSet_Input_Subset(class Framework_Server* obj, __int8 ptr_praiseEventId);

    protected:

    private:

    };
}