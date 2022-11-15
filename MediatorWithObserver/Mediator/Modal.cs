using MediatorWithObserver.Observer;
using MediatorWithObserver.UIControls;

namespace MediatorWithObserver.Mediator;

public class Modal
{
    private readonly TextBox _textBox = new();
    private readonly Button _saveButton = new();
    private readonly TitleList _titleList = new();

    public Modal()
    {
        _textBox.AddEventHandler(new TextHandler(this));
        _titleList.AddEventHandler(new TitleHandler(this));
    }

    public void Display()
    {
        _titleList.SetSelection("First Title");
        _textBox.SetContent("");
        _textBox.SetContent("Second Title");
        Console.WriteLine("TextBox: " + _textBox.GetContent());
        Console.WriteLine("Button: " + _saveButton.IsEnabled());
    }

    public void TitleChanged()
    {
        var content = _textBox.GetContent();
        var isEmpty = (string.IsNullOrEmpty(content));
        _saveButton.SetEnabled(!isEmpty);
    }

    public void ArticleSelected()
    {
        _textBox.SetContent(_titleList.GetSelection());
        _saveButton.SetEnabled(true);
    }
}