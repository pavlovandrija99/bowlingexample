using BowlingExampleTemplate.Bowling;
using System;

namespace BowlingExampleTemplate
{
    static class Program
    {
        static void Main(string[] args)
        {
            BowlingLogic bowling = new BowlingLogic();
            int result = TryPerfectGame(bowling);
            Console.WriteLine("Score: " + result);
        }

        static int TryPerfectGame(BowlingLogic bowling)
        {
            int score = 0;
            for(int i = 0; i<12; i++)
            {
                bowling.ThrowBall(10);
            }
            score = bowling.CheckScore();
            return score;
        }
    }
}
