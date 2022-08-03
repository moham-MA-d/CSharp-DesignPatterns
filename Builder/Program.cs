using Builder.ConcreteBuilder;
using Builder.Director;
using Builder.Models;

var items = new List<Food>
{
    new ("Sandwich", 10, Food.Size.Medium),
    new ("Pizza", 10, Food.Size.Medium),
    new ("Kebab", 10, Food.Size.Large),
    new ("Chicken", 10, Food.Size.Small),
};

var reportBuilder = new ReportBuilder(items);
            
Console.WriteLine("====================Report Builder With Director====================");

var director = new ReportDirector(reportBuilder);
director.BuildCompleteReport();
var directorReport = reportBuilder.GetReport();
Console.WriteLine(directorReport.Display());


Console.WriteLine("====================Report Builder Without Director====================");

var fluentReport = reportBuilder
    .AddReportTitle()
    .AddReportSpec()
    .AddReportDateTime(DateTime.Now)
    .GetReport();
Console.WriteLine(fluentReport.Display());


Console.ReadKey();