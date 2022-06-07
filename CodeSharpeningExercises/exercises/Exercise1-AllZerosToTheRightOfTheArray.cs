using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSharpeningExercises.exercises
{
    public class AllZerosToTheRightOfTheArray
    {
        public static int[] MovingAllZerosToTheRight(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                    continue;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == 0)
                        continue;
                    
                    numbers[i] = numbers[j];
                    numbers[j] = 0;
                    break;
                }
            }
            return numbers;
        }

    }
}
