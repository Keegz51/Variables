using System;
using System.Linq;

namespace Variables
{
    class Program
    {

        
        static void Main(string[] args)
        {


            //Console.WriteLine("Please enter a Number between 1 -10");
            //string number = Console.ReadLine();

            // Validate(number);

            // Validate2(number);


            /* Console.WriteLine("Please enter the Speed Limit?");
             string speedLimit = Console.ReadLine();

             Console.WriteLine("Please enter the Speed?");
             string speed = Console.ReadLine();

             Components.Speed(Convert.ToInt32(speedLimit), Convert.ToInt32(speed));*/

            //Console.WriteLine(Utility___Strings.consecutive2("1-2-3-4"));


            Console.WriteLine(@"Please enter a number corresponding to the function
1. Consecutive Numbers
2. Count Vowels
3. To Pascal Case
4. Convert String to TimeSpan");
            int number = Convert.ToInt32(Console.ReadLine());

            switch(number)
            {
                case 1:
                    Console.WriteLine(Utility___Strings.consecutive3("5-4-3-2-1-0"));
                    break;

                case 2:
                    String word = "determined to succeed";
                    Console.WriteLine(Utility___Strings.countVowels(word));
                    break;

                case 3:
                    String sentence = "determined to succeed";
                    Console.WriteLine(Utility___Strings.toPascalCase(sentence));                    
                    break;

                case 4:
                    Console.WriteLine("Please enter a time :");
                    String time = Console.ReadLine();
                    if (Utility___Strings.isValid(time))
                    {
                        Console.WriteLine("Time is valid");
                    }
                    else Console.WriteLine("Time is not valid");
                    break;
            }


           

        }
    }
}
