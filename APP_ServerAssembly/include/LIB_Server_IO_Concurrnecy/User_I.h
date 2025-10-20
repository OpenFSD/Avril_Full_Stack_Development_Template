#pragma once

namespace Avril_FSD
{
	class User_I
	{
	public:
		User_I();
		virtual ~User_I();
		class Praise0_Input* Get_Praise0_Input();
		class Praise1_Input* Get_Praise1_Input();
		class Praise2_Input* Get_Praise2_Input();

	protected:

	private:
		static void Set_Praise0_Input(class Praise0_Input* praise0_I);
		static void Set_Praise1_Input(class Praise1_Input* praise1_I);
		static void Set_Praise2_Input(class Praise2_Input* praise2_I);

	};
}