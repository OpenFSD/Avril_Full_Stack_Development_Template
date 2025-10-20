// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_EXPORTS
#define LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_API __declspec(dllexport)
#else
#define LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_API __declspec(dllimport)
#endif

namespace Avril_FSD
{
	// This class is exported from the dll
	class LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_API CLIBWriteEnableForThreadsAtSERVEROUTPUTRECIEVE {
	public:
		CLIBWriteEnableForThreadsAtSERVEROUTPUTRECIEVE(void);
		// TODO: add your methods here.
		static void* Initialise_WriteEnable();
		static void Write_End(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* obj, unsigned char coreId);
		static void Write_Start(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* obj, unsigned char coreId);

	private:
		static class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* Get_Framework_WriteEnable();
		static void Set_writeEnable(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* writeEnable);

	};
}

extern LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_API int nLIBWriteEnableForThreadsAtSERVEROUTPUTRECIEVE;

LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_API int fnLIBWriteEnableForThreadsAtSERVEROUTPUTRECIEVE(void);
