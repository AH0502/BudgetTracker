namespace ConsoleApp;

public class Menu
{
    /// <summary>
    /// Displays a list of choices in the main menu.
    /// </summary>
    public static void DisplayMain()
    {
        Console.WriteLine("+---------------------------------+");
        Console.WriteLine("Welcome to the Budget Tracker!");
        Console.WriteLine("1. Add Transaction");
        Console.WriteLine("2. Clear Transactions");
        Console.WriteLine("3. Edit Transactions");
        Console.WriteLine("4. View Summary");
        Console.WriteLine("5. List All Transactions");
        Console.WriteLine("6. Save Transactions");
        Console.WriteLine("q. Exit");
        Console.WriteLine("Select an option: ");
        Console.WriteLine("+---------------------------------+");
    }

    public static void CreateTransaction(int id, BudgetTracker budgetTracker)
    {
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
    }

}