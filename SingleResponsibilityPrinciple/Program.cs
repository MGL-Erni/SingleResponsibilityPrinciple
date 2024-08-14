namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // raw text, given
            string rawText = "THIS IS CONTENT!!!!!!";

            // instantiate the classes we will use
            // each has their own WELL-DEFINED responsibilities
            ReportGenerator reportGenerator = new ReportGenerator();
            ReportFormatter reportFormatter = new ReportFormatter();
            TextFileManager textFileManager = new TextFileManager();

            // generate a report using the raw text
            Report myReport = reportGenerator.GenerateReport(rawText);

            // format the report
            string myFormattedReportContents = reportFormatter.FormatReport(myReport);

            // save the report to a file
            textFileManager.SaveToFile("my_report.txt", myFormattedReportContents);

            // load the saved report contents
            string mySavedReportContents = textFileManager.LoadFromFile("my_report.txt");

            // output its contents
            Console.WriteLine(mySavedReportContents);

            // put them in a report again, if you wish
            Report myReloadedReport = reportGenerator.GenerateReport(mySavedReportContents);
            Console.WriteLine(reportFormatter.FormatReport(myReloadedReport));
        }
    }
}
