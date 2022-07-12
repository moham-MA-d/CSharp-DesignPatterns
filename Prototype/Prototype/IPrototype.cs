namespace Prototype.Prototype;

public interface IPrototype
{
    IPrototype ShallowCopy();
    IPrototype DeepCopy();
    void Display();
}