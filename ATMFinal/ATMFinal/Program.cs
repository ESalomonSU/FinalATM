using System;

namespace ATMFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Options options = new Options();
            int Pin, Correct = -1;

            do
            {
                try
                {
                    options.title();
                    Console.WriteLine(" Pin: ");
                    Pin = int.Parse(Console.ReadLine());
                    Correct = user.validPin(Pin);

                    if (Correct != -1)
                    {
                        Console.Clear();
                        Console.WriteLine(" Correct Pin \n");
                        options.optUser(Correct);
                    }

                    else
                    {
                        Console.WriteLine(" Incorrect Pin, Try Again \n");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid data");
                    Correct = -1;
                }
            }
            while (Correct != -1);
                
        }
    }
}
