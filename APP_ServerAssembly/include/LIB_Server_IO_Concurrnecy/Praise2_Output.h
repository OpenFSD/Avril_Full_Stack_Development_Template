#pragma once

namespace Avril_FSD
{
	class Praise2_Output
	{
	public:
		Praise2_Output();
		virtual ~Praise2_Output();

		std::vector<float> GetPosition();
		std::vector<float> GetFowards();
		std::vector<float> GetUp();
		std::vector<float> GetRight();

		void SetPosition(std::vector<float> position);
		void SetFowards(std::vector<float> fowards);
		void SetUp(std::vector<float> up);
		void SetRight(std::vector<float> right);
	};
}