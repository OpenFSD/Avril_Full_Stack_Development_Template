#pragma once

namespace Avril_FSD
{
	class Settings
	{
	public:
		Settings();
		virtual ~Settings();

		float Get_fov();
		int Get_refreshRate();
		bool Get_systemInitialised();
		char Get_screenSize_X();
		char Get_screenSize_Y();

		void Set_fov(float fov);
		void Set_refreshRate(int refreshRate);
		void Set_systemInitialised(bool isSystemInitialised);
		void Set_screenSize_X(char screenSize_X);
		void Set_screenSize_Y(char screenSize_Y);
	};
}

