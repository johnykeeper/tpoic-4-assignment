using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Transactions;

namespace tpoic_4_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jonathan
            string name, name2, item1, item2;
            int age, age2;
            double money;
            string firstname;
            string lastname;
            int grade;
            int id;
            string login;
            double average, num1, num2, num3, price1, price2, total, discount, finalprice, subtotal, tax;

            Console.WriteLine("hello. what is your name");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hi, " + name + " How old are you?");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();
            Console.WriteLine("oh wow you're only " + age + " how much money do you make a hour?");
            double.TryParse(Console.ReadLine(), out money);
            
            Console.WriteLine("enter the information below");
            Console.WriteLine("press Enter to continue after each question");
            Console.WriteLine("first name: ");
            firstname = Console.ReadLine();
            Console.WriteLine("last name:");
            lastname = Console.ReadLine();
            Console.WriteLine("grade");
            int.TryParse(Console.ReadLine(),out grade);
            Console.WriteLine("student id");
            int.TryParse(Console.ReadLine(),out id);
            Console.WriteLine("login name ");
            login = Console.ReadLine();
            Console.WriteLine("average");
            double.TryParse(Console.ReadLine(),out average);
            Console.WriteLine();
            Console.WriteLine("this is your information");
            Console.WriteLine("firstname: " + firstname);
            Console.WriteLine("lastname: " + lastname);
            Console.WriteLine("grade: " + grade);
            Console.WriteLine("student ID: " + id);
            Console.WriteLine("login name: " + login);
            Console.WriteLine("average: " + average);
            Console.ReadLine();
            Console.WriteLine("hello. what is your name?");
            name2 = Console.ReadLine();
            Console.WriteLine("Hi " + name2 + " how old are you?");
            int.TryParse (Console.ReadLine(),out age2);
            Console.WriteLine("did you know that in 5 years you will be " + (age2 + 5));
            Console.ReadLine();
            Console.WriteLine("give me a 3 didgit number and i will add them then devide them by two");
            Console.WriteLine("enter your first number");
            double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("enter your second number");
            double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("enter your third number");
            double.TryParse(Console.ReadLine(), out num3);
            Console.WriteLine((num1 + num2 + num3) / 2 + " is your answer");
            Console.WriteLine();
            Console.WriteLine("enter in two items and there prices below");
            Console.WriteLine("enter the first item");
            item1 = Console.ReadLine();
            Console.WriteLine("enter the first items price");
            double.TryParse(Console.ReadLine(), out price1);
            Console.WriteLine("enter the second item");
            item2 = Console.ReadLine();
            Console.WriteLine("enter the second items price");
            double.TryParse(Console.ReadLine(), out price2);
            total = price1 + price2;
            discount = total * .2;
            subtotal = total - discount;
            tax = discount * .13;
            finalprice = subtotal * 1.13;
            Console.WriteLine("receipt");
            Console.WriteLine("");
            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Price:  " + price1.ToString("c"));
            Console.WriteLine("Item 2: " + item2);
            Console.WriteLine("Price:  " + price2.ToString("c"));
            Console.WriteLine("====================");
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Discount (20%) : " + discount.ToString("c"));
            Console.WriteLine("Subtotal: " + subtotal.ToString("c"));
            Console.WriteLine("Tax (13%) : " + tax.ToString("c"));
            Console.WriteLine("====================");
            Console.WriteLine("Total owed: " + finalprice.ToString("c") );

            
        }
    }
}
