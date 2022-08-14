namespace TemplateMethod.Models;

public class Pizza : Food
{
    protected override void PrepareIngredients()
    {
        Console.WriteLine($"{nameof(Pizza)} is Preparing Ingredients");
    }

    protected override void Cook()
    {
        Console.WriteLine($"{nameof(Pizza)} is Cooking");
    }

    protected override void Design()
    {
        Console.WriteLine($"{nameof(Pizza)} is Designing");
    }
    
}