using System.Collections.Generic;
using System

namespace BudgetTracker;

public class BudgetTracker
{
    private List<Transaction> transactions = new List<Transaction>();

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
        }
    }
}