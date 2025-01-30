namespace ConsoleApp;

public class Category
{
    public required string Name { get; set; }
    public string? Description { get; set; }

    public override string ToString() => Name;
    

}