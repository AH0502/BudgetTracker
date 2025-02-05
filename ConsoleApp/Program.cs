using System;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp;

class Program
{
    static void Main()
    {
        var budgetTracker = new BudgetTracker();
        budgetTracker.ImportTransactions("../transaction.csv");
        Console.WriteLine("Transactions loaded successfully!");
      
        int i = 0;
        int id;
        while (true)
        {
            /* Console.WriteLine("\n Welcome to the Budget Tracker!"); // will implement home method at some point
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. Clear Transactions");
            Console.WriteLine("3. View Summary");
            Console.WriteLine("4. List All Transactions");
            Console.WriteLine("5. Save Transactions");
            Console.WriteLine("q. Exit");
            Console.WriteLine("Select an option: "); */

            Menu.DisplayMain();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    i++;
                    id = i;
                    /* Console.Write("Enter Category: ");
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
                        Type = type */
                    Menu.CreateTransaction(id, budgetTracker);
                    
                    break;

                case "2":
                    budgetTracker.ClearTransactions();
                    Console.WriteLine("Transaction(s) cleared!");
                    break;

                 case "3":
                    budgetTracker.EditTransaction();
                    break;


                case "4":
                    budgetTracker.DisplaySummary();
                    break;

                case "5":
                    budgetTracker.ListTransactions();
                    break;

                case "6":
                    budgetTracker.SaveTransaction("../transaction.csv");
                    Console.WriteLine("Transaction(s) saved!");
                    break;

                case "q":
                    Console.WriteLine("Goodbye!");
                    return;

                default: 
                    Console.WriteLine("Invalid option.");
                    break;


            }
            
        }

    }
}
