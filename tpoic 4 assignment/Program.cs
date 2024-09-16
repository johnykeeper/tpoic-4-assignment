namespace tpoic_4_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jonathan
            string name;
            int age;
            double money;


            Console.WriteLine("hello. what is your name");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Hi, " + name + " How old are you?");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();
            Console.WriteLine("oh wow you're only " + age + " how much money do you make a hour?");
            double.TryParse(Console.ReadLine(), out money);
        }
    }
}
