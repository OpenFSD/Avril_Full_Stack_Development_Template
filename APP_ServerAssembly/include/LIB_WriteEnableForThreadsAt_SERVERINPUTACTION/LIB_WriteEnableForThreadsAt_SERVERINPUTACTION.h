// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the LIBWRITEENABLEFORTHREADSATSERVERINPUTACTION_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// LIBWRITEENABLEFORTHREADSATSERVERINPUTACTION_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef LIBWRITEENABLEFORTHREADSATSERVERINPUTACTION_EXPORTS
#define LIBWRITEENABLEFORTHREADSATSERVERINPUTACTION_API __declspec(dllexport)
#else
#define LIBWRITEENABLEFORTHREADSATSERVERINPUTACTION_API __declspec(dllimport)
#endif


namespace Avril_FSD
{
	// This class is exported from the dll
	class LIBWRITEENABLEFORTHREADSATSERVERINPUTACTION_API CLIBWriteEnableForThreadsAtSERVERINPUTACTION {
	public:
		CLIBWriteEnableForThreadsAtSERVERINPUTACTION(void);
		// TODO: add your methods here.
		static void* Initialise_WriteEnable();
		static void Write_End(class WriteEnableForThreadsAt_SERVERINPUTACTION_Framework* obj, unsigned char coreId);
		static void Write_Start(class WriteEnableForThreadsAt_SERVERINPUTACTION_Framework* obj, unsigned char coreId);

	private:
		static class WriteEnableForThreadsAt_SERVERINPUTACTION_Framework* Get_Framework_WriteEnable();
		static void Set_writeEnable(class WriteEnableForThreadsAt_SERVERINPUTACTION_Framework* writeEnable);
	};
}

extern LIBWRITEENABLEFORTHREADSATSERVERINPUTACTION_API int nLIBWriteEnableForThreadsAtSERVERINPUTACTION;

LIBWRITEENABLEFORTHREADSATSERVERINPUTACTION_API int fnLIBWriteEnableForThreadsAtSERVERINPUTACTION(void);
