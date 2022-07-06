using Builder.Models.Complex;

namespace Builder.Builder;

public interface IReportBuilder
{
    IReportBuilder AddReportTitle();
    IReportBuilder AddReportSpec();
    IReportBuilder AddReportDateTime(DateTime dateTime);
    Report GetReport();
}