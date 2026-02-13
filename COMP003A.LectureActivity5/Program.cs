namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to Module 5!");
                Console.WriteLine(mainOnlyNumber);
            }
            DisplayWelcome();

			int mainOnlyNumber = 100;

			//

			static void DisplayUserInfo(string name, int age)
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
            }

            string name = "Alex";
            int age = 20;

            DisplayUserInfo(name, age);

            //

            static int CalculateSum(int num1, int num2)
            {
                return num1 + num2; 
            }

            //

            int sum = CalculateSum(7, 8);
            Console.WriteLine($"The sum is: {sum}");

            //

            if (true)
            {
                int insideIf = 50;
                Console.WriteLine($"Inside if: {insideIf}");
            }

            Console.WriteLine(insideIf);

            //

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Loop counter: {i}");
            }

            Console.WriteLine(i);

            /*
             
              1. Variables declared inside Main cannot be used inside other methods because methods have their own scope
              2. Variables declared inside blocks only exist inside that block
              3.Scope improves safety by preventing accidental use to variables where they shouldn't be accessible
              
             */
        }
    }
}
