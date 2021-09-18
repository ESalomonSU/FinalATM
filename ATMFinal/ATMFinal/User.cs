using System;
namespace ATMFinal
{
    public class User
    {
        public int[] pin = { 1234 };
        public int[] available = { 1001, 2001, 3001 };

        public int validPin(int Pin)
        {
            int success = -1;
            for (int i = 0; i < pin.Length; i++)
            {
                if (pin[i] == Pin)
                {
                    success = i;
                }
            }
            return success;
        }
    }
}
