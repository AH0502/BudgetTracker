using System.Collections.Generic;
using System.IO;
using System;
using Microsoft.VisualBasic.FileIO;


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

    public static void ImportTransactions(String filepath, BudgetTracker tracker)
    {

        using var parser = new TextFieldParser(filepath);
    
        parser.TextFieldType = FieldType.Delimited; // Default value is delimited 
        parser.SetDelimiters(new string[] {","});

        while (!parser.EndOfData)
        {
            var row = parser.ReadFields();
            int id = Int32.Parse(row[0]);
            string category = row[1];
            decimal amount = Decimal.Parse(row[2]);
            DateTime date = DateTime.Parse(row[3]);
            string type = row[4];

            var cat = new Category(category);


            tracker.AddTransaction(new Transaction
            {
                Id = id,
                Category = cat,
                Amount = amount,
                Date = date,
                Type = type
            });

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