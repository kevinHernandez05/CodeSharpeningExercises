using CodeSharpeningExercises.exercises;
using Xunit;

namespace CodeSharpeningExercises.Test
{
    public class RomanToIntTest
    {
        [Fact]
        public void RomanToInt_Test1()
        {
            string input = "III";
            int expected = 3;

            int result = Exercise2_RomanToInt.RomanToInt(input);

            Assert.Equal(expected, result);

        }
        
        [Fact]
        public void RomanToInt_Test2()
        {
            string input = "LVIII";
            int expected = 58;

            int result = Exercise2_RomanToInt.RomanToInt(input);

            Assert.Equal(expected, result);

        }
        
        [Fact]
        public void RomanToInt_Test3()
        {
            string input = "MCMXCIV";
            int expected = 1994;

            int result = Exercise2_RomanToInt.RomanToInt(input);

            Assert.Equal(expected, result);

        }
    }
}