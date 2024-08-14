namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// `ReportGenerator` only handles GENERATING REPORTS (Report objects), as per its name.
    /// i.e. Taking text and putting into a `Report` object.
    /// Reports can be of MANY FORMATS but generated reports would be of a UNIFORM format.
    /// Format is another layer of complexity that is not directly concerned with the content of the report itself.
    /// </summary>
    internal class ReportGenerator
    {
        public Report GenerateReport(string content)
        {
            return new Report() { Content = content };
        }
    }
}
