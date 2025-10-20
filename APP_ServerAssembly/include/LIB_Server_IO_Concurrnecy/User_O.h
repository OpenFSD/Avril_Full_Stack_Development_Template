#pragma once

namespace Avril_FSD
{
	class User_O
	{
	public:
		User_O();
		virtual ~User_O();
		class Praise0_Output* Get_Praise0_Output();
		class Praise1_Output* Get_Praise1_Output();
		class Praise2_Output* Get_Praise2_Output();

	protected:

	private:
		static void Set_Praise0_Output(class Praise0_Output* praise0_O);
		static void Set_Praise1_Output(class Praise1_Output* praise1_O);
		static void Set_Praise2_Output(class Praise2_Output* praise2_O);
	};
}