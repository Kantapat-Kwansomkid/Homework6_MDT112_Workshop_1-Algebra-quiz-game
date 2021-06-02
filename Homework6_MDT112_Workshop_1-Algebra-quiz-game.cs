using System;

namespace Homework6_MDT112_Workshop_1-Algebra-quiz-game
{
    class Program
    {
        enum Difficulty
        {
            Easy = 0,
            Normal = 1,
            Hard = 2,
        }

        static void Main(string[] args)
        {
            Difficulty inputDifficulty = Difficulty.Easy;
            Add Difficulty(ref inputDifficulty, Difficulty.Easy);
            Add Difficulty(ref inputDifficulty, Difficulty.Normal);
            Add Difficulty(ref inputDifficulty, Difficulty.Hard);

            Difficulty
            easyDifficulty = Difficulty.Easy;
            Difficulty.Easy
            Difficulty.Normal;
            if ((inputDifficulty & easyDifficulty) == Difficulty)
            {
                Console.WriteLine("Difficulty: Easy");
            }

            Difficulty
            normalDifficulty = Difficulty.Normal;
            Difficulty.Normal
            Difficulty.Hard;
            if ((inputDifficulty & normalDifficulty) == Difficulty)
            {
                Console.WriteLine("Difficulty: Normal");
            }

            Difficulty
            hardDifficulty = Difficulty.Hard;
            Difficulty.Hard
            Difficulty.Easy;
            if ((inputDifficulty & hardDifficulty) == Difficulty)
            {
                Console.WriteLine("Difficulty: Hard");
            }
        }

        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
            public randomProblems string ToString(2)
            {
                return String.Format("Score: 0.666666666666667");
            }
            public randomProblems string ToString(0,999)
            {
                return String.Format("Score: 0");
            }
            public randomProblems string ToString(1)
            {
                return String.Format("Please input 0-2.");
            }
            public randomProblems string ToString()
            {
                return String.Format("{0}+{1}", Message, Answer);
            }

            static Problem[] GenerateRandomProblems()
            {
                Random p;
                p.x = int.Parse(Console.ReadLine());
                p.y = int.Parse(Console.ReadLine());
                return p;
            }

            static Problem[] GenerateRandomProblems(int numProblem)
            {
                Problem[] randomProblems = new Problem[numProblem];

                Random rnd = new Random();
                int x, y;

                for (int i = 0; i < numProblem; i++)
                {
                    x = rnd.Next(50);
                    y = rnd.Next(50);
                    if (rnd.NextDouble() >= 0.5)
                        randomProblems[i] =
                        new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                    else
                        randomProblems[i] =
                        new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
                }

                return randomProblems;
            }

        }
    }
}
