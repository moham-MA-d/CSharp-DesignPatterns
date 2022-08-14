namespace TemplateMethod.Models;

public class Kebab : Food
{
    protected override void PrepareIngredients()
    {
        Console.WriteLine($"{nameof(Kebab)} is Preparing Ingredients");
    }

    protected override void Cook()
    {
        Console.WriteLine($"{nameof(Kebab)} is Cooking");
    }

    protected override void Design()
    {
        Console.WriteLine($"{nameof(Kebab)} is Designing");
    }
}