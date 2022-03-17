using System;

namespace ConsoleApp1
{
    public class Program
    {
        static public decimal Balance = 0;

        public static void UserInterface()
        {
            int transaction = 0;
            while (transaction < 4)
            {
                decimal amount = 0;
                Console.WriteLine($"Current balance is {Balance} $");
                Console.WriteLine("----------------");
                Console.WriteLine("Please choose transaction number");
                Console.WriteLine("----------------");
                Console.WriteLine($"1- ViewBalance");
                Console.WriteLine($"2- Withdraw");
                Console.WriteLine($"3- Deposit");
                Console.WriteLine($"4- Exit");
                try
                {
                    transaction = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException )
                {
                    Console.WriteLine("Sorry its not valid number");
                    continue;
                }
                if (transaction > 4 || transaction <= 0)
                {
                    Console.WriteLine("Please enter number between 1 / 4");
                    continue;
                }
                else if (transaction == 1)
                {
                    Console.WriteLine($"You Balance is : {Class1.ViewBalance()} $ ");
                }
                else if (transaction == 2)
                {
                    Console.WriteLine("Please enter the amount to Withdraw");
                    try
                    {
                        amount = Convert.ToDecimal(Console.ReadLine());
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("Sorry its not valid number");
                        continue;
                    }

                    decimal withdrawNum = Class1.Withdraw(amount);

                    if (withdrawNum >= 0 && withdrawNum <= Balance)
                    {
                        Console.WriteLine($"Done !! Current balance is {Balance} $");
                    }
                    else
                    {
                        Console.WriteLine(withdrawNum > 0 ? "Please enter amount more than zero" : $"Balance is not enough : {Balance} $");
                    }

                }
                else if (transaction == 3)
                {
                    Console.WriteLine("Please enter the amount to Deposit");
                    try
                    {
                        amount = Convert.ToDecimal(Console.ReadLine());
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("Sorry its not valid number");
                        continue;
                    }
                    decimal depositNum = Class1.Deposit(amount);
                    if (depositNum > 0)
                    {
                        Console.WriteLine($"Done !! Current balance is {Balance} $");
                    }
                    else
                    {
                        Console.WriteLine("Please enter amount more than zero");
                    }
                }

            }

            Console.WriteLine("See you again");
        }
        static void Main(string[] args)
        {
            UserInterface();
        }
    }
}
