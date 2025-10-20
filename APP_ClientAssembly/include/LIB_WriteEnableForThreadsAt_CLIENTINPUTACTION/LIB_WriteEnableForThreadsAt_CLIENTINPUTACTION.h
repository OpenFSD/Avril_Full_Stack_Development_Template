// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the LIBWRITEENABLEFORTHREADSATCLIENTINPUTACTION_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// LIBWRITEENABLEFORTHREADSATCLIENTINPUTACTION_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef LIBWRITEENABLEFORTHREADSATCLIENTINPUTACTION_EXPORTS
#define LIBWRITEENABLEFORTHREADSATCLIENTINPUTACTION_API __declspec(dllexport)
#else
#define LIBWRITEENABLEFORTHREADSATCLIENTINPUTACTION_API __declspec(dllimport)
#endif

namespace Avril_FSD
{
	// This class is exported from the dll
	class LIBWRITEENABLEFORTHREADSATCLIENTINPUTACTION_API CLIBWriteEnableForThreadsAtCLIENTINPUTACTION {
	public:
		CLIBWriteEnableForThreadsAtCLIENTINPUTACTION(void);
		// TODO: add your methods here.
		static void* Initialise_WriteEnable();
		static void Write_End(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj, unsigned char coreId);
		static void Write_Start(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj, unsigned char coreId);

	private:
		static class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* Get_Framework_WriteEnable();
		static void Set_writeEnable(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* writeEnable);
	};
}

extern LIBWRITEENABLEFORTHREADSATCLIENTINPUTACTION_API int nLIBWriteEnableForThreadsAtCLIENTINPUTACTION;

LIBWRITEENABLEFORTHREADSATCLIENTINPUTACTION_API int fnLIBWriteEnableForThreadsAtCLIENTINPUTACTION(void);
