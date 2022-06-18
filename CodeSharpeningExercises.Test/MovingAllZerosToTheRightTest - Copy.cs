using CodeSharpeningExercises.exercises;
using Xunit;

namespace CodeSharpeningExercises.Test
{
    public class MovingAllZerosToTheRightTest
    {
        [Fact]
        public void MovingAllZerosToTheRight()
        {
            int[] input = new int[] { 5, 6, 7, 0, 9, 0, 3, 0, 6, 7 };
            int[] expected = new int[] { 5, 6, 7, 9, 3, 6, 7, 0, 0, 0 };

            int[] result = AllZerosToTheRightOfTheArray.MovingAllZerosToTheRight(input);

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}