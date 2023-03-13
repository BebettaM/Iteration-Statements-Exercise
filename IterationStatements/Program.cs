namespace IterationStatements
{
    public class Program
    {
        public static object Conslole { get; private set; }

        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)

            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Trees()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual (int a, int b)
        {
            if (a == b)
            {
                return true;
            }
         else
            {
                return false;
            }
        }   
        
        //Write a method to check whether a given number is even or odd
        public static bool IsEven (int a)
        {
           if (a % 2 != 0)
            {
                return false;
            }
           else
            {
                return true;
            }
        }   
        
        //Write a method to check whether a given number is positive or negative
         public static void PositiveOrNegative (int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num}) is negative");
            }
            else
            {
                Console.WriteLine($"{num}) is neither positive nor negative"); 
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void AgeCheck()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine ("Please enter your age:");
                userAge = int.TryParse(Console.ReadLine(), out result);
            } while (!userAge);
            if (result < 18)
            {
                Console.WriteLine("Sorry you are not old enough to vote");
            }
            else
            {
                Console.WriteLine("Congrat! You can vote!");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange()
        {

            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer");
                userResponse = int.TryParse(Console.ReadLine(), out result);
            } while (!userResponse);

            if (result >= -10 && result <= 10)
            {
                Console.WriteLine($"{result} is between -10 & 10");
            }

            else
            {
                Console.WriteLine($"{result} is not between -10 & 10");
            }
              
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable ()
        {
            bool count;
            int userInput;
            do
            {
                Console.WriteLine("Enter an integer");
                count = int.TryParse(Console.ReadLine(), out userInput);
            } while (!count);
            for (var x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {userInput} = {x * userInput}");
            }
        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            MultTable();
        }
    }
}
