namespace BudgetTracker.src;

public class Transaction
{
    public int Id { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; } // "Income" or "Expense"

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Category}: {Type} ${Amount}";

    }
}  