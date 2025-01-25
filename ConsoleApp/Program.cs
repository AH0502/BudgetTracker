// See https://aka.ms/new-console-template for more information
using System;

namespace BudgetTracker.src;

class Program
{
    static void Main()
    {
        BudgetTracker budgetTracker = new BudgetTracker();

        while (true)
        {
            Console.WriteLine("\n Welcome to the Budget Tracker!");
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. View Summary");
            Console.WriteLine("3. List All Transactions");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Category: ");
                    string category = Console.ReadLine();

                    Console.WriteLine("Enter Amount: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Enter Type (Income/Expense): ");
                    string type = Console.ReadLine();

                    budgetTracker.AddTransaction(new Transaction
                    {
                        Category = category,
                        Amount = amount,
                        Date = DateTime.Now,
                        Type = type
                    });
                    break;

                case "2":
                    budgetTracker.DisplaySummary();
                    break;

                case "3":
                    budgetTracker.ListTransactions();
                    break;

                case "4":
                    Console.WriteLine("Goodbye!");
                    return;

                default: 
                    Console.WriteLine("Invalid option.");
                    break;


            }
            
        }

    }
}
