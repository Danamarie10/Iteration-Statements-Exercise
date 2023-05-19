namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        //DONE
         
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        //DONE

        //Write a method to accept two integers as parameters and check whether they are equal or not
        //DONE

        //Write a method to check whether a given number is even or odd
        //DONE

        //Write a method to check whether a given number is positive or negative
        //DONE
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        //DONE 

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        // Done
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbers1();
            Console.WriteLine("-----------------------------");
            PrintNumbers2();
            Console.WriteLine("-----------------------------");
            
            bool result = CheckEquality(5, 6); 
            if (result)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }
            Console.WriteLine("-----------------------------");
            
            bool isNumEven = IsEven(5);
            if (isNumEven)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.WriteLine("------------------------------");

            string checkSign = CheckSign(-20);
            Console.WriteLine("The number is: " + checkSign);
            Console.WriteLine("------------------------------");

            CanVote();
            Console.WriteLine("------------------------------");
            CheckNumberRange();
            Console.WriteLine("------------------------------");

            DisplayTable(3);
            


        }
        public static void PrintNumbers1()
        {
            for (int num = 1000; num >= -1000; num--)
            {
                Console.WriteLine(num);
            }
        }
        public static void PrintNumbers2()
        {
        for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        public static bool CheckEquality(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
                
            }
            else
            {
                return false;
               
            }
        }
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string CheckSign(int number)
        {
            if (number >0)
            {
                return "Positive";
            }
            else if (number <0)
            {
                return "Negative";
            }
            else
            {
                return "Zero";
            }
        }
        public static void CanVote()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligibile to vote");
            }
        }
        public static void CheckNumberRange()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= -10 && number <= 10)
            {
                Console.WriteLine("The number is within the range of -10 and 10");
            }
            else
            {
                Console.WriteLine("That number is not in the range of -10 and 10");
            }
        }
        public static void DisplayTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
    
}
