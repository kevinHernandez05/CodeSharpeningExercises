using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSharpeningExercises.exercises
{
    public class Exercise2_RomanToInt
    {
        static Dictionary<char, int> romanValueToNumber = new Dictionary<char, int>();

        public static int RomanToInt(string number)
        {
            int result = 0;

            romanValueToNumber.Add('I', 1);
            romanValueToNumber.Add('V', 5);
            romanValueToNumber.Add('X', 10);
            romanValueToNumber.Add('L', 50);
            romanValueToNumber.Add('C', 100);
            romanValueToNumber.Add('D', 500);
            romanValueToNumber.Add('M', 1000);


            for (int i = 0; i < number.Length; i++)
            {
                char currentRomanChar = number[i];
                romanValueToNumber.TryGetValue(currentRomanChar, out int num);

                if (i + 1 < number.Length && romanValueToNumber[number[i + 1]] > romanValueToNumber[currentRomanChar])
                    result -= num;

                else
                    result += num;

            }

            return result;
        }

    }
}
