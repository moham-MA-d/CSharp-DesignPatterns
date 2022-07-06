using Builder.Builder;
using Builder.Models;
using Builder.Models.Complex;

namespace Builder.ConcreteBuilder;

public class ReportBuilder: IReportBuilder
{
    private Report _report;
    private readonly IEnumerable<Food> _items;

    public ReportBuilder(IEnumerable<Food> items)
    {
        Reset();
        _items = items;
    }

    public IReportBuilder AddReportTitle()
    {
        _report.Title = "Report Result: \n";
        return this;
    }
    public IReportBuilder AddReportSpec()
    {
        _report.Specification = string.Join(Environment.NewLine, _items.Select(product =>
            $"Product: {product._name} \n" +
            $"Price: {product._price} \n" +
            $"Size: {product._size} \n"));
        return this;
    }
    public IReportBuilder AddReportDateTime(DateTime dateTime)
    {
        _report.DateAndTime = $"Report generated on {dateTime}";
        return this;
    }

    public Report GetReport()
    {
        var finalReport = _report;
        Reset();

        return finalReport;
    }

    private void Reset()
    {
        _report = new Report();
    }
}