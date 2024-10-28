namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ROCK - PAPER - SCISSORS";
            Console.WriteLine("WELCOME TO ROCK - PAPER - SCISSORS\n");
            Console.WriteLine("- - - - - - - - - - - - - - - -");

            string inputCPU, inputPlayer;
            int randomInt;
            bool playAgain = true;


            while (playAgain)
            {
                int scoreCPU = 0;
                int scorePlayer = 0;


                while (scoreCPU < 3 && scorePlayer < 3)
                {
                    Random random = new Random();
                    randomInt = random.Next(1, 4);

                    while (true)
                    {
                        Console.Write("\nCHOOSE ROCK, PAPER OR SCISSORS: ");
                        inputPlayer = Console.ReadLine().ToUpper();

                        if (inputPlayer == "ROCK" || inputPlayer == "PAPER" || inputPlayer == "SCISSORS")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nINVALID INPUT.\n");
                        }
                    }

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("\nCOMPUTER CHOSE ROCK");

                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("\nDRAW!\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("\nPLAYER WINS!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("\nCPU WINS!\n");
                                scoreCPU++;
                            }

                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("\nCOMPUTER CHOSE PAPER");

                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("\nCPU WINS!\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("\nDRAW!\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("\nPLAYER WINS!\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("\nCOMPUTER CHOSE SCISSORS");

                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("\nPLAYER WINS!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("\nCPU WINS!\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("\nDRAW!\n");
                            }
                            break;
                    }

                    Console.WriteLine("SCORES [ PLAYER: {0} | CPU: {1} ]\n", scorePlayer, scoreCPU);
                    Console.WriteLine("- - - - - - - - - - - - - - - -");
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("\nPLAYER WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("\nCPU WON!");
                }

                Console.WriteLine("\nWOULD YOU LIKE TO PLAY AGAIN (Y/N)");
                string loop = Console.ReadLine().ToUpper();
                playAgain = loop == "Y";
                if (playAgain) Console.Clear();
            }
        }
    }
}
