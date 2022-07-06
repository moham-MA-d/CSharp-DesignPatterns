using Builder.ConcreteBuilder;
using Builder.Director;
using Builder.Models;

var items = new List<Food>
{
    new Food("Sandwich", 10, Food.Size.Medium),
    new Food("Pizza", 10, Food.Size.Medium),
    new Food("Kebab", 10, Food.Size.Large),
    new Food("Chicken", 10, Food.Size.Small),
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