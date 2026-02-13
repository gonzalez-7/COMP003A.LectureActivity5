namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to Module 5!");
            }
            DisplayWelcome();

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
        }
    }
}
