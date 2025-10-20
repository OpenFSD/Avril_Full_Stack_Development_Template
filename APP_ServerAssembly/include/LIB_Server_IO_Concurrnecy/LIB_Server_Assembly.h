#pragma once
#ifdef LIBSERVERCONCURRENCY_EXPORTS
#define LIBSERVERCONCURRENCY_API __declspec(dllexport)
#else
#define LIBSERVERCONCURRENCY_API __declspec(dllimport)
#endif

namespace Avril_FSD
{
	class LIBSERVERCONCURRENCY_API CLIBServerConcurrencyLibrary {
	public:
		CLIBServerConcurrencyLibrary();
		static void* Initialise_Server_Assembly();
		static bool Get_Flag_IsStackLoaded_Server_InputAction(class Avril_FSD::Framework_Server* obj);
		static bool Get_Flag_IsStackLoaded_Server_OutputRecieve(class Avril_FSD::Framework_Server* obj);
		static bool Get_Flag_IsInitialised_Avril_FSD_ServerAssembly(class Avril_FSD::Framework_Server* obj);
		static void Pop_Stack_Output(class Avril_FSD::Framework_Server* obj);
		static void Push_Stack_InputPraises(class Avril_FSD::Framework_Server* obj);

// Praise Event Id
		static __int8 Get_PraiseEventId(class Avril_FSD::Framework_Server* obj);
		static void Set_PraiseEventId(class Avril_FSD::Framework_Server* obj, __int8 value);
// Praise 0 Data
		static bool Get_Praise0_Input_IsPingActive(class Avril_FSD::Framework_Server* obj);
		static void Set_Praise0_Input_IsPingActive(class Avril_FSD::Framework_Server* obj, bool value);
		static bool Get_Praise0_Output_IsPingActive(class Avril_FSD::Framework_Server* obj);
		static void Set_Praise0_Output_IsPingActive(class Avril_FSD::Framework_Server* obj, bool value);
// Praise 1 Data
		static float Get_Praise1_Input_mouseDelta_X(class Avril_FSD::Framework_Server* obj);
		static float Get_Praise1_Input_mouseDelta_Y(class Avril_FSD::Framework_Server* obj);
		static void Set_Praise1_Input_mouseDelta_X(class Avril_FSD::Framework_Server* obj, float value);
		static void Set_Praise1_Input_mouseDelta_Y(class Avril_FSD::Framework_Server* obj, float value);
		static Eigen::Vector3d Get_Praise1_Output_Player_Fowards(class Avril_FSD::Framework_Server* obj);
		static Eigen::Vector3d Get_Praise1_Output_Player_Up(class Avril_FSD::Framework_Server* obj);
		static Eigen::Vector3d Get_Praise1_Output_Player_Right(class Avril_FSD::Framework_Server* obj);
		static void Set_Praise1_Output_Player_Fowards(class Avril_FSD::Framework_Server* obj, Eigen::Vector3d value);
		static void Set_Praise1_Output_Player_Up(class Avril_FSD::Framework_Server* obj, Eigen::Vector3d value);
		static void Set_Praise1_Output_Player_Right(class Avril_FSD::Framework_Server* obj, Eigen::Vector3d value);
// Praise 0 Data

// TODO: add your methods here.
	};
}