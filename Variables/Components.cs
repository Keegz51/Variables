using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Components
    {

        public static void Validate(string number)
        {

            try
            {
                if (Convert.ToInt32(number) > 0 && Convert.ToInt32(number) <= 10)
                {
                    Console.WriteLine("Valid");
                }

                else
                {
                    Console.WriteLine("Invalid");

                }

            }

            catch (Exception)
            {

                Console.WriteLine("Please enter a Number");
                Console.WriteLine("Please enter a Number between 1 -10");
                number = Console.ReadLine();

                Validate(number);

            }
        }


        public static void Validate2(string number)
        {

            while (!number.All(char.IsDigit))
            {
                Console.WriteLine("Please enter a Number");
                Console.WriteLine("Please enter a Number between 1 -10");
                number = Console.ReadLine();
            }

            if (Convert.ToInt32(number) > 0 && Convert.ToInt32(number) <= 10)
            {
                Console.WriteLine("Valid");
            }

            else
            {
                Console.WriteLine("Invalid");

            }

        }

        public static void Speed(int speedLimit, int speed)
        {

            int demerit = (speed - speedLimit) / 5;

            if (demerit > 1 && demerit < 13)
            {
                Console.WriteLine(demerit + "demrit/s awarded");
            }
            else if (demerit > 12)
            {
                Console.WriteLine("License Suspended");
            }
        }


    }
}
