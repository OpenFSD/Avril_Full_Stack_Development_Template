#pragma once

namespace Avril_FSD
{
	class User_Alg
	{
	public:
		User_Alg();
		virtual ~User_Alg();
		class Praise0_Algorithm* Get_Praise0_Algorithm();
		class Praise1_Algorithm* Get_Praise1_Algorithm();
		class Praise2_Algorithm* Get_Praise2_Algorithm();

	protected:

	private:
		static void Set_Praise0_Algorithm(class Praise0_Algorithm* praise0_A);
		static void Set_Praise1_Algorithm(class Praise1_Algorithm* praise1_A);
		static void Set_Praise2_Algorithm(class Praise2_Algorithm* praise2_A);
	};
}

