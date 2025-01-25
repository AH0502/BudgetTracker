using System.Collections.Generic;
using System.IO;
using System;

namespace ConsoleApp;

public class BudgetTracker
{
    private List<Transaction> transactions = new List<Transaction>();

    public void SaveTransaction(String filepath)
    {
        using (var writer = new StreamWriter(filepath))
        {
            foreach (var transaction in transactions)
                writer.WriteLine($"{transaction.Id},{transaction.Category}, {transaction.Amount},{transaction.Date},{transaction.Type} ");
        }
    }

    public void AddTransaction (Transaction transaction)
    {
        transactions.Add(transaction);
        Console.WriteLine("Transaction added successfully!");
    }

    public void DisplaySummary()
    {
        decimal income = 0, expense = 0;
        foreach (var transaction in transactions)
        {
            if (transaction.Type == "Income")
                income += transaction.Amount;
            else
                expense += transaction.Amount;
        }
        Console.WriteLine($"\nSummary:\nTotal Income: ${income}\nTotal Expense: ${expense}\nBalance: ${income - expense}\n");
    }

    public void ListTransactions()
    {
        Console.WriteLine("\nAll Transactions:");
        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}