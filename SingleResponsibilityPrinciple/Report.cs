namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// `Report` class solely manages the CONTENT of a report.
    /// Likewise, its only (important) property is `Content`, which stores the content of the report itself.
    /// </summary>
    internal class Report
    {
        public string Content { get; set; }

        public Report()
        {
        }
    }
}
