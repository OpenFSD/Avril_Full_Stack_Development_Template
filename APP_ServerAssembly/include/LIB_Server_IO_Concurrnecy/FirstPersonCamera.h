#pragma once

namespace Avril_FSD
{
	class FirstPersonCamera
	{
	public:
		FirstPersonCamera();
		virtual ~FirstPersonCamera();

		void Update_Pitch(float deltaDegY);
		void Update_Yaw(float deltaDegX);
		void UpdateVectors(float pitch, float yaw);

		Eigen::Vector3d Get_offset();
		float Get_pitch();
		float Get_yaw();
		Eigen::Vector3d Get_fowards();
		Eigen::Vector3d Get_up();
		Eigen::Vector3d Get_right();

		void Set_offset(Eigen::Vector3d offset);
		void Set_pitch(float pitch);
		void Set_yaw(float yaw);
		void Set_fowards(Eigen::Vector3d fowards);
		void Set_up(Eigen::Vector3d up);
		void Set_right(Eigen::Vector3d right);

	private:

	};
}