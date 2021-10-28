using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingExampleTemplate.Bowling
{
    public class BowlingLogic
    {

		int[] throws = new int[21];
		int currentThrow;

		public void ThrowBall(int pins)
		{
			throws[currentThrow] = pins;
			currentThrow++;
		}

		public int CheckScore()
		{

			int score = 0;
			int frame = 0;

			for (int i = 0; i < 10; i++)
			{

				if (IsSpare(frame))
				{
					score += 10 + SpareBonus(frame);
					frame += 2;

				}
				else if (IsStrike(frame))
				{
					score += 10 + StrikeBonus(frame);
					frame += 1;
				}
				else
				{
					score += SumPins(frame);
					frame += 2;
				}
			}

			return score;
		}



		public bool IsSpare(int frame)
		{
			return SumPins(frame) == 10;
		}

		public bool IsStrike(int frame)
		{
			return throws[frame] == 10;
		}

		public int SumPins(int frame)
		{
			return throws[frame] + throws[frame + 1];
		}

		public int SpareBonus(int frame)
		{
			return throws[frame + 2];
		}

		public int StrikeBonus(int frame)
		{
			return throws[frame + 1] + throws[frame + 2];
		}
	}
}
