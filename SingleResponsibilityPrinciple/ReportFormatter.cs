namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// `ReportFormatter` is the class that actually handles FORMATTING a `Report` into something else. e.g. TEXT
    /// There may be many ways to format a report, so we want to SEPARATE IT FROM THE REPORT ITSELF and its contents.
    /// </summary>
    internal class ReportFormatter
    {
        public string FormatReport(Report report)
        {
            // convert the report into another format (e.g. lowercase plaintext)
            return report.Content.ToLower();
        }
    }
}
