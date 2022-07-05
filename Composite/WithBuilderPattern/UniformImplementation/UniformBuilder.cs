namespace Composite.WithBuilderPattern.UniformImplementation;

public class UniformBuilder
{
    private UniformCompositeWb _foodType;
    public UniformCompositeWb BusinessType { get; }

    public UniformBuilder(string businessName)
    {
        this.BusinessType = new UniformCompositeWb(businessName);
        this._foodType = this.BusinessType;
    }

    public UniformCompositeWb AddFoodType(string name)
    {
        var foodType = new UniformCompositeWb(name);
        _foodType.Add(foodType);
        _foodType = foodType;
        return foodType;
    }

    public UniformLeafWb AddFood(string name, int orderCount)
    {
        var food = new UniformLeafWb(name, orderCount);
        this._foodType.Add(new UniformLeafWb(name, orderCount));
        return food;
    }

        // Note the iterative stack based solution. It could implement based on recursion as well.
    public UniformCompositeWb SelectFoodType(string foodType)
    {
        var foodTypeStack = new Stack<UniformCompositeWb>();
        foodTypeStack.Push(this.BusinessType);
        while (foodTypeStack.Any())
        {
            var current = foodTypeStack.Pop();
            if (current._name == foodType)
            {
                this._foodType = current;
                return current;
            }
            foreach (var item in current._children.OfType<UniformCompositeWb>())
            {
                foodTypeStack.Push(item);
            }
        }
        throw new InvalidOperationException($"Food type '{foodType}' not found!");
    }

}