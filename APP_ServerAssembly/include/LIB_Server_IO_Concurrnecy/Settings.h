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
		float Get_screenSize_X();
		float Get_screenSize_Y();

		void Set_fov(float fov);
		void Set_refreshRate(int refreshRate);
		void Set_systemInitialised(bool isSystemInitialised);
		void Set_screenSize_X(float screenSize_X);
		void Set_screenSize_Y(float screenSize_Y);
	};
}

