namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputCPU, inputPlayer;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scoreCPU = 0;
                int scorePlayer = 0;
            }

            while (scoreCPU < 3 && scorePlayer < 3)
            {
                Console.WriteLine("CHOOSE BETWEEN ROCK, PAPER and SCISSORS: ");
                inputPlayer = Console.ReadLine.ToUpper();

                Random random = new Random();
                randomInt = random.Next(1, 4);


                switch(randomInt)
                {
                    case 1: 
                        inputCPU = "ROCK";
                        Console.WriteLine("COMPUTER CHOSE ROCK");
                    break;

                    case 2:
                        inputCPU = "PAPER";
                        Console.WriteLine("COMPUTER CHOSE PAPER");
                    break;

                    case 3:
                        inputCPU = "SCISSORS";
                        Console.WriteLine("COMPUTER CHOSE SCISSORS");
                    break;
                }
            }
        }
    }
}
