namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a project and try to get data from the console. Store data into variables. Show data that has been stored.

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {name} {surname}, you are {age} years old");
        }
    }
}