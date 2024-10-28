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
            }
        }
    }
}
