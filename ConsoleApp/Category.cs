namespace ConsoleApp;

public class Category
{
    public required string Name { get; set; }
    public string? Description { get; set; }

    public Category(string name, string description = "")
    {
        if (String.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name), "Category name can't be null or whitespace!");
        Name = name;
        Description = description;
    }
    public override string ToString() => Name;
    

}