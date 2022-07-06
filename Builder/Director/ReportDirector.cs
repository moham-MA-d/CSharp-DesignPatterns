using Builder.Builder;
namespace Builder.Director;

public class ReportDirector
{
    private readonly IReportBuilder _builder;

    public ReportDirector(IReportBuilder concreteBuilder)
    {
        _builder = concreteBuilder;
    }

    public void BuildCompleteReport()
    {
        _builder.AddReportTitle();
        _builder.AddReportSpec();
        _builder.AddReportDateTime(DateTime.Now);
    }
}