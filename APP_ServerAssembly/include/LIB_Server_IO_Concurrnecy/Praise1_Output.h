#pragma once

namespace Avril_FSD
{
	class Praise1_Output
	{
	public:
		Praise1_Output();
		virtual ~Praise1_Output();
		Eigen::Vector3d GetFowards();
		Eigen::Vector3d GetRight();
		Eigen::Vector3d GetUp();

		void SetFowards(Eigen::Vector3d fowards);
		void SetRight(Eigen::Vector3d right);
		void SetUp(Eigen::Vector3d up);
	};
}