#pragma once

namespace Avril_FSD
{
    class Player
    {
    public:
        Player();
        virtual ~Player();
		class FirstPersonCamera* Get_camera_FP();
		bool Get_isFirstMove();
		bool Get_isFirstMouseMove();
		bool Get_cameraSelector();
		float Get_cameraSpeed();
		float Get_sensitivity();

		std::vector<float> Get_player_Position();
		Eigen::Vector3d Get_Front();
		Eigen::Vector3d Get_Right();
		Eigen::Vector3d Get_Up();
		std::vector<float> Get_mouse_Position();

		void Set_camera_FP(FirstPersonCamera* camera);
		void Set_isFirstMove(bool value);
		void Set_isFirstMouseMove(bool value);
		void Set_cameraSpeed(float cameraSpeed);
		void Set_sensitivity(float sensitivity);

		void Set_player_Position_X(float position_X);
		void Set_player_Position_Y(float position_Y);
		void Set_player_Position_Z(float position_Z);
		void Set_mouse_Position_X(float position_Y);
		void Set_mouse_Position_Y(float position_Y);
		void Set_front(Eigen::Vector3d front);
		void Set_right(Eigen::Vector3d right);
		void Set_up(Eigen::Vector3d up);
    };
}