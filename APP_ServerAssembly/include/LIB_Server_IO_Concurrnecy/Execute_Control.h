#pragma once

namespace Avril_FSD
{
    class Execute_Control
    {
    public:
        Execute_Control(__int8 number_Implemented_Cores);
        virtual ~Execute_Control();
        bool GetFlag_SystemInitialised(class Framework_Server* obj);
        bool GetFlag_ThreadInitialised(__int8 coreId);
        void SetConditionCodeOfThisThreadedCore(__int8 coreId);

    protected:

    private:
        void SetFlag_ThreadInitialised(__int8 coreId);
    };
}