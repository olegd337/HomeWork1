namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a project and try to initialize variables with the next types: int, double, string, char, and bool. Show values from variables via console.

            int someNumber = 54;
            double someDouble = 10.5;
            string someString = "Hello dear friends"; 
            char someChar = 'C';
            bool someBool = false;

            Console.WriteLine($"int - {someNumber}");
            Console.WriteLine($"string - {someString}");
            Console.WriteLine($"char - {someChar}");
            Console.WriteLine($"bool - {someBool}");

        }
    }
}