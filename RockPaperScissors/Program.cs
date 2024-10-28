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


                while (scoreCPU < 3 && scorePlayer < 3)
                {
                    Console.WriteLine("CHOOSE BETWEEN ROCK, PAPER and SCISSORS: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random random = new Random();
                    randomInt = random.Next(1, 4);


                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("COMPUTER CHOSE ROCK");

                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }

                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("COMPUTER CHOSE PAPER");

                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!\n\n")
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("COMPUTER CHOSE SCISSORS");

                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!\n\n")
                            }
                            break;

                        default:
                            Console.WriteLine("INVALID ENTRY. TRY AGAIN");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }

                Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN (Y/N)");
                string loop = Console.ReadLine();
                playAgain = loop == "y";
                if (playAgain) Console.Clear();
            }
        }
    }
}
