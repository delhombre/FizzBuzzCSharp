namespace FizzBuzz.Models
{
    public class FizzBuzzGame
    {
        public static string Play(int minNumber, int maxNumber)
        {
            string result = "";

            while (minNumber <= maxNumber)
            {
                result += GetFizzBuzzResult(minNumber++);
            }

            return result;
        }

        private static string GetFizzBuzzResult(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}
