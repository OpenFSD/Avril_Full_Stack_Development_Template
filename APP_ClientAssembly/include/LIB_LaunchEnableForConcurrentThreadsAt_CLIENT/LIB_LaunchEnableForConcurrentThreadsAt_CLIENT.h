// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the LIBLAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// LIBLAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef LIBLAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_EXPORTS
#define LIBLAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_API __declspec(dllexport)
#else
#define LIBLAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_API __declspec(dllimport)
#endif

namespace Avril_FSD
{
	// This class is exported from the dll
	class LIBLAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_API CLIBLaunchEnableForConcurrentThreadsAtCLIENT {
	public:
		CLIBLaunchEnableForConcurrentThreadsAtCLIENT(void);
		// TODO: add your methods here.
		static void* Initialise_LaunchEnableForConcurrentThreadsAt();

		static void Request_Wait_Launch(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, unsigned char concurrent_CoreId);
		static void Thread_End(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework*, unsigned char concurrent_CoreId);

		static __int8 Get_coreId_To_Launch(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj);
		static bool Get_Flag_Active(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj);
		static bool Get_Flag_ConcurrentCoreState(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, unsigned char concurrent_CoreId);
		static bool Get_Flag_Idle(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj);
		static bool Get_State_LaunchBit(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj);
		static void Set_state_ConcurrentCore(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, unsigned char concurrent_CoreId, bool value);

	private:
		static class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* Get_LaunchEnableForConcurrentThreadsAt_CLIENT_Framework();
		static void Set_LaunchEnableForConcurrentThreadsAt_CLIENT_Framework(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* framework);
	};
}
extern LIBLAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_API int nLIBLaunchEnableForConcurrentThreadsAtCLIENT;

LIBLAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_API int fnLIBLaunchEnableForConcurrentThreadsAtCLIENT(void);
