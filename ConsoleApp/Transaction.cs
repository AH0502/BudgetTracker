namespace ConsoleApp;

public class Transaction
{
    public int Id { get; set; }
    public required string Category { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public required string Type { get; set; } // "Income" or "Expense"

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Category}: {Type} ${Amount}";

    }
}  