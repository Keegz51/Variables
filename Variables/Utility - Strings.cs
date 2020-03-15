using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Utility___Strings
    {

        #region Consecutive
        public static String consecutive(String input)
        {
            string[] inputArr = input.Split('-');
            string output = "consecutive";

            for (int i = 0; i < inputArr.Length; i++)
            {

                if (i < inputArr.Length - 1)
                {
                    if (Convert.ToInt32(inputArr[i]) - Convert.ToInt32(inputArr[i + 1]) == 1 || Convert.ToInt32(inputArr[i]) - Convert.ToInt32(inputArr[i + 1]) == -1)
                    {

                        continue;

                    }

                    else
                    {
                        output = "Not Consecutive";
                        break;
                    }
                }
            }


            return output;
        }

        #endregion

        #region Consecutive2
        public static String consecutive2(String input)
        {
            string[] inputArr = input.Split('-');
            string output = "consecutive";
            string direction = "";

            int num = 0;

            foreach(var c in inputArr)
            {

                int intC = Convert.ToInt32(c);

                if(intC==Convert.ToInt32(inputArr[0]))
                {
                    num = Convert.ToInt32(c);
                    continue;
                }

                 if (intC == Convert.ToInt32(inputArr[1]))
                {
                    if(intC-num==1)
                    {
                        direction = "up";
                    }
                    else if(intC-num==-1)
                    {
                        direction = "down";
                    }
                    
                }

                if(intC==(num+1) && direction=="up")
                {

                    num = intC;
                    continue;

                }

                 else if(intC == (num - 1) && direction=="down")
                {
                    num = intC;
                    continue;
                }

                else
                {
                    output = "nonconsecutive";
                    break;
                }


            }


            return output;
        }
        #endregion

        #region Consecutive3
        public static String consecutive3 (string input)
        {
            string output = "consecutive";

            string[] inputArr = input.Split('-');

            int j = Convert.ToInt32(inputArr[0]);


            if (direction(inputArr)=="up")
            {
                for (int i = Convert.ToInt32(inputArr[0]); i < inputArr.Length; i++)
                {
                    if (j == i)
                    {
                        j++;
                        continue;
                    }
                    else
                    {
                        output = "nonconsecutive";
                        break;
                    }
                }
            }

            else if (direction(inputArr) == "down")
                for (int i = Convert.ToInt32(inputArr[0]); i < inputArr.Length; i--)
            {
                if (j == i)
                {
                    j--;
                    continue;
                }
                else
                {
                    output = "nonconsecutive";
                    break;
                }
            }

            else if(direction(inputArr)=="unordered")
            {
                output = "nonconsecutive";
            }

            return output;
        }
        #endregion

        #region Direction
        static String direction(string[] inputArr)
        {
            string direction = "";

            if(Convert.ToInt32(inputArr[0])-Convert.ToInt32(inputArr[1])==1)
            {
                direction = "up";
            }
            else if (Convert.ToInt32(inputArr[0]) - Convert.ToInt32(inputArr[1]) == -1)
            {
                direction = "down";
            }
            else
            {
                direction = "unordered";
            }


            return direction;

        }
        #endregion

        #region Vowel work
        static bool isVowel(char vowel)
        {
            bool isVowel = false;
            vowel = Convert.ToChar(vowel.ToString().ToLower());

            if(vowel.Equals('a')|| vowel.Equals('e')||vowel.Equals('i')||vowel.Equals('o') || vowel.Equals('u'))
            {
                isVowel = true;
            }

            return isVowel;
        }

        public static int countVowels(string word)
        {
            int count = 0;

            foreach(char c in word)
            {
                if(isVowel(c))
                {
                    count++;
                }
            }
            
            return count;
        }

        #endregion

        #region ToPascalCase

        public static String toPascalCase(string sentence)
        {
            string PascalCase = "";

            string[] strArr = sentence.Split(' ');

            foreach (String word in strArr)
            {

                char firstLetter = Convert.ToChar(word.Substring(0,1).ToUpper());

                string remainder = word.Substring(1).ToLower();

                PascalCase += firstLetter + remainder;
                
            }


            return PascalCase;
        }



        #endregion

        #region MakeTimeSpan

        static TimeSpan StringToTimeSpan(string stringTime)
        {
            int hours = 0, minutes = 0, seconds = 0;

            string[] strArr = stringTime.Split(':');

            for(int i=0;i<strArr.Length;i++)
            {

                
                
                if(i<=strArr.Length)
                {

                    if(i==0)
                    {
                        if(Convert.ToInt32(strArr[i]) > 23)
                        {
                            return new TimeSpan(0, 0, 0);
                        }

                        hours = Convert.ToInt32(strArr[i]);
                    }

                    else if(i==1)
                    {
                        if (Convert.ToInt32(strArr[i]) > 59)
                        {
                            return new TimeSpan(0, 0, 0);
                        }
                        minutes = Convert.ToInt32(strArr[i]);
                    }

                    else if(i==2 && Convert.ToInt32(strArr[i]) <= 59)
                    {
                        if (Convert.ToInt32(strArr[i]) <= 59)
                        {
                            return new TimeSpan(0, 0, 0);
                        }

                        seconds = Convert.ToInt32(strArr[i]);
                    }

                }

            }
            TimeSpan timeSpan = new TimeSpan(hours, minutes, seconds);


            return timeSpan;
        }

        public static bool isValid(string timeSpan)
        {
            bool valid = false;

            if(StringToTimeSpan(timeSpan)!=new TimeSpan(0,0,0))
            {
                valid = true;
            }


            return valid;
        }

        #endregion
    }

}
