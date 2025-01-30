using System;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp;

class Program
{
    static void Main()
    {
        BudgetTracker budgetTracker = new BudgetTracker();
        int i = 0;
        int id;
        while (true)
        {
            Console.WriteLine("\n Welcome to the Budget Tracker!");
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. View Summary");
            Console.WriteLine("3. List All Transactions");
            Console.WriteLine("4. Save Transactions");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    i++;
                    id = i;
                    Console.Write("Enter Category: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Description: ");
                    string description = Console.ReadLine();

                    var category = new Category(name, description);

                    Console.WriteLine("Enter Amount: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Enter Type (Income/Expense): ");
                    string type = Console.ReadLine();

                    budgetTracker.AddTransaction(new Transaction
                    {
                        Id = id,
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
                    budgetTracker.SaveTransaction("../transaction.csv");
                    return;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default: 
                    Console.WriteLine("Invalid option.");
                    break;


            }
            
        }

    }
}
