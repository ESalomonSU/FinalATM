using System;
namespace ATMFinal
{
    public class Options
    {

        User myUser = new User();
        private int choise;

        public int choice { get; private set; }

        public void optUser(int Correct)
        {
            do
            {
                title();
                Console.WriteLine(" Select An Option \n");
                Console.WriteLine("1. Balance");
                Console.WriteLine("2. Exit\n");
                choice = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        balance(Correct);
                        Console.WriteLine("Press Any Key To Continue...");
                        Console.ReadKey();
                        Console.Clear();
                        optUser(Correct);
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
            while (choice != 2);
        }

        private void balance(int Correct)
        {
            title();
            Console.WriteLine($"Balance ${myUser.available[Correct]} \n");
        }

        public void title()
        {
            Console.WriteLine(" Welcom to the ATM ");
        }
    }
}
