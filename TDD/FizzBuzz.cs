namespace TDD
{
    public class FizzBuzzE
    {
        public string FizzBuzz(int p)
        {

            if (p % 3 == 0 && p % 5 == 0)
            {
                return ("FizzBuzz");
            }
            else if (p % 3 == 0)
            {
                return ("Fizz");
            }
            else if (p % 5 == 0)
            {
                return ("Buzz");
            }
            else
            {
                return "";
            }
        }

      /*  static void Main(string[] args)
        {
            FizzBuzzE fizzBuzz = new FizzBuzzE();

            fizzBuzz.FizzBuzz(100);
        }*/
    }
}

