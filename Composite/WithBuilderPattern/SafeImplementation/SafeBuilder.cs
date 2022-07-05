namespace Composite.WithBuilderPattern.SafeImplementation;

public class SafeBuilder
{
    private SafeCompositeWb _foodType;
    public SafeCompositeWb BusinessType { get; }

    public SafeBuilder(string businessName)
    {
        this.BusinessType = new SafeCompositeWb(businessName);
        this._foodType = this.BusinessType;
    }

    public SafeCompositeWb AddFoodType(string name)
    {
        var foodType = new SafeCompositeWb(name);
        _foodType.Add(foodType);
        _foodType = foodType;
        return foodType;
    }

    public SafeLeafWb AddFood(string name, int orderCount)
    {
        var food = new SafeLeafWb(name, orderCount);
        this._foodType.Add(new SafeLeafWb(name, orderCount));
        return food;
    }

        // Note the iterative stack based solution. It could implement based on recursion as well.
    public SafeCompositeWb SelectFoodType(string foodType)
    {
        var foodTypeStack = new Stack<SafeCompositeWb>();
        foodTypeStack.Push(this.BusinessType);
        while (foodTypeStack.Any())
        {
            var current = foodTypeStack.Pop();
            if (current._name == foodType)
            {
                this._foodType = current;
                return current;
            }
            foreach (var item in current._children.OfType<SafeCompositeWb>())
            {
                foodTypeStack.Push(item);
            }
        }
        throw new InvalidOperationException($"Food type '{foodType}' not found!");
    }

}