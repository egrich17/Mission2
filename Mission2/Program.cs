using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome user to game and ask how many rolls they want
            Console.WriteLine("Welcome to the dice game!");
            Console.WriteLine("How many times would you like to roll the dice?");
            int rolls = Convert.ToInt32(Console.ReadLine());

            // Initialize random numbers to represent the 2 dice
            int randomNum1;
            int randomNum2;

            // Initialize array to hold the number of each roll
            int [] rollsArray = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            // Import random class to be able to roll random numbers
            Random random = new Random();

            // Loop through each roll until we reach the total rolls suggested by user
            for (int i = 0; i < rolls; i++)
            {
                // Generate random number for dice roll1 and dice roll2
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();
                randomNum1 = random.Next(1, 7);
                randomNum2 = random.Next(1, 7);

                // if sum of dice = 2, add 1 to the 2s (posiiton 0 of the array)
                if (randomNum1 + randomNum2 == 2)
                {
                    rollsArray[0] = rollsArray[0] + 1;

                }

                // else if sum of dice = 3, add 1 to the 3s (posiiton 1 of the array)
                else if (randomNum1 + randomNum2 == 3)
                {
                    rollsArray[1] = rollsArray[1] + 1;
                }

                // else if sum of dice = 4, add 1 to the 4s (posiiton 2 of the array)
                else if (randomNum1 + randomNum2 == 4)
                {
                    rollsArray[2] = rollsArray[2] + 1;
                }

                // else if sum of dice = 5, add 1 to the 5s (posiiton 3 of the array)
                else if (randomNum1 + randomNum2 == 5)
                {
                    rollsArray[3] = rollsArray[3] + 1;
                }

                // else if sum of dice = 6, add 1 to the 6s (posiiton 4 of the array)
                else if (randomNum1 + randomNum2 == 6)
                {
                    rollsArray[4] = rollsArray[4] + 1;
                }

                // else if sum of dice = 7, add 1 to the 7s (posiiton 5 of the array)
                else if (randomNum1 + randomNum2 == 7)
                {
                    rollsArray[5] = rollsArray[5] + 1;
                }

                // else if sum of dice = 8 add 1 to the 8s (posiiton 6 of the array)
                else if (randomNum1 + randomNum2 == 8)
                {
                    rollsArray[6] = rollsArray[6] + 1;
                }

                // else if sum of dice = 9, add 1 to the 9s (posiiton 7 of the array)
                else if (randomNum1 + randomNum2 == 9)
                {
                    rollsArray[7] = rollsArray[7] + 1;
                }

                // else if sum of dice = 10, add 1 to the 10s (posiiton 8 of the array)
                else if (randomNum1 + randomNum2 == 10)
                {
                    rollsArray[8] = rollsArray[8] + 1;
                }

                // else if sum of dice = 11, add 1 to the 11s (posiiton 9 of the array)
                else if (randomNum1 + randomNum2 == 11)
                {
                    rollsArray[9] = rollsArray[9] + 1;
                }

                // if sum of dice = 12, add 1 to the 12s (posiiton 10 of the array)
                else
                {
                    rollsArray[10] = rollsArray[10] + 1;
                }
            }
            // calculate % for each dice roll category
            float twelve = (float)rollsArray[10] / rolls * 100;
            float eleven = (float)rollsArray[9] / rolls * 100;
            float ten = (float)rollsArray[8] / rolls * 100;
            float nine = (float)rollsArray[7] / rolls * 100;
            float eight = (float)rollsArray[6] / rolls * 100;
            float seven = (float)rollsArray[5] / rolls * 100;
            float six = (float)rollsArray[4] / rolls * 100;
            float five = (float)rollsArray[3] / rolls * 100;
            float four = (float)rollsArray[2] / rolls * 100;
            float three = (float)rollsArray[1] / rolls * 100;
            float two = (float)rollsArray[0] / rolls * 100;

            // Print the results in a histogram
            Console.WriteLine("Results: ");
            Console.WriteLine();
            
            Console.Write("Two: ");
            for (int i = 0; i < two; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("Three: ");
            for (int i = 0; i < three; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Four:");
            for (int i = 0; i < four; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Five: ");
            for (int i = 0; i < five; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Six: ");
            for (int i = 0; i < six; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Seven: ");
            for (int i = 0; i < seven; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Eight: ");
            for (int i = 0; i < eight; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Nine: ");
            for (int i = 0; i < nine; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
             
            Console.Write("Ten: ");
            for (int i = 0; i < ten; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Eleven: ");
            for (int i = 0; i < eleven; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.Write("Twelve: ");
            for (int i = 0; i < twelve; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for playing!");
        }
    }
}
