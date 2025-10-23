#ifdef LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_EXPORTS
#define LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_API __declspec(dllexport)
#else
#define LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_API __declspec(dllimport)
#endif

namespace Avril_FSD
{
	class LIBWRITEENABLEFORTHREADSATSERVEROUTPUTRECIEVE_API Library_WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE {
	public:
		Library_WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE();
		static void* Initialise_WriteEnable();
		static void Write_End(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* obj, unsigned char coreId);
		static void Write_Start(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* obj, unsigned char coreId);

	private:
		static class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* Get_Framework_WriteEnable();
		static void Set_writeEnable(class WriteEnableForThreadsAt_SERVEROUTPUTRECIEVE_Framework* writeEnable);
	};
}