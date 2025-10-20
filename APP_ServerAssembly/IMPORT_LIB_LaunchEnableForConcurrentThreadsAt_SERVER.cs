using System.Runtime.InteropServices;
using System.Security;

namespace Avril_FSD
{
    [SuppressUnmanagedCodeSecurity]
    public static class Library_For_LaunchEnableForConcurrentThreadsAt_SERVER
	{
        [DllImport("LIBLaunchEnableForConcurrentThreadsAtSERVER.dll", EntryPoint = "?Initialise_LaunchEnableForConcurrentThreadsAt@CLIBLaunchEnableForConcurrentThreadsAtSERVER@Avril_FSD@@SAPAXXZ")]
        public static extern IntPtr Initialise_LaunchEnableForConcurrentThreadsAt();

		[DllImport("LIBLaunchEnableForConcurrentThreadsAtSERVER.dll", EntryPoint = "?Request_Wait_Launch@CLIBLaunchEnableForConcurrentThreadsAtSERVER@Avril_FSD@@SAXPAVLaunchEnableForConcurrentThreadsAt_SERVER_Framework@2@E@Z")]
		public static extern void Request_Wait_Launch(IntPtr obj, byte concurrent_CoreId);

		[DllImport("LIBLaunchEnableForConcurrentThreadsAtSERVER.dll", EntryPoint = "?Thread_End@CLIBLaunchEnableForConcurrentThreadsAtSERVER@Avril_FSD@@SAXPAVLaunchEnableForConcurrentThreadsAt_SERVER_Framework@2@E@Z")]
		public static extern void Thread_End(IntPtr obj, byte concurrent_CoreId);

		[DllImport("LIBLaunchEnableForConcurrentThreadsAtSERVER.dll", EntryPoint = "?Get_coreId_To_Launch@CLIBLaunchEnableForConcurrentThreadsAtSERVER@Avril_FSD@@SADPAVLaunchEnableForConcurrentThreadsAt_SERVER_Framework@2@@Z")]
		public static extern byte Get_coreId_To_Launch(IntPtr obj);

		[DllImport("LIBLaunchEnableForConcurrentThreadsAtSERVER.dll", EntryPoint = "?Get_Flag_Active@CLIBLaunchEnableForConcurrentThreadsAtSERVER@Avril_FSD@@SA_NPAVLaunchEnableForConcurrentThreadsAt_SERVER_Framework@2@@Z")]
		public static extern bool Get_Flag_Active(IntPtr obj);

		[DllImport("LIBLaunchEnableForConcurrentThreadsAtSERVER.dll", EntryPoint = "?Get_Flag_ConcurrentCoreState@CLIBLaunchEnableForConcurrentThreadsAtSERVER@Avril_FSD@@SA_NPAVLaunchEnableForConcurrentThreadsAt_SERVER_Framework@2@E@Z")]
		public static extern bool Get_Flag_ConcurrentCoreState(IntPtr obj, byte concurrent_CoreId);

		[DllImport("LIBLaunchEnableForConcurrentThreadsAtSERVER.dll", EntryPoint = "?Get_Flag_Idle@CLIBLaunchEnableForConcurrentThreadsAtSERVER@Avril_FSD@@SA_NPAVLaunchEnableForConcurrentThreadsAt_SERVER_Framework@2@@Z")]
		public static extern bool Get_Flag_Idle(IntPtr obj);

		[DllImport("LIBLaunchEnableForConcurrentThreadsAtSERVER.dll", EntryPoint = "?Get_State_LaunchBit@CLIBLaunchEnableForConcurrentThreadsAtSERVER@Avril_FSD@@SA_NPAVLaunchEnableForConcurrentThreadsAt_SERVER_Framework@2@@Z")]
		public static extern bool Get_State_LaunchBit(IntPtr obj);

		[DllImport("LIBLaunchEnableForConcurrentThreadsAtSERVER.dll", EntryPoint = "?Set_state_ConcurrentCore@CLIBLaunchEnableForConcurrentThreadsAtSERVER@Avril_FSD@@SAXPAVLaunchEnableForConcurrentThreadsAt_SERVER_Framework@2@E_N@Z")]
		public static extern void Set_State_ConcurrentCoreState(IntPtr obj, byte concurrent_CoreId, bool value);
	}
}