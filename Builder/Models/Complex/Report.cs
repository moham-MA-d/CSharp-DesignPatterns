using System.Text;
namespace Builder.Models.Complex;

public class Report
{
    public string Title;
    public string Specification;
    public string DateAndTime;

    public string Display()
    {
        return new StringBuilder()
            .AppendLine(Title)
            .AppendLine(Specification)
            .AppendLine(DateAndTime)
            .ToString();
    }
}