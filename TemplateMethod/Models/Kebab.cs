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

    protected override void Decorate()
    {
        Console.WriteLine($"{nameof(Kebab)} is Decorating");
    }
}