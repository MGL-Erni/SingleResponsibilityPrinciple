namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// `TextFileManager` solely handles FILE OPERATIONS such as saving and loading text files into the program.
    /// It interacts with an external API / service, i.e. the host filesystem.
    /// I had chosen to accept TEXT (string) rather than taking / interacting with a a `Report` object
    /// in order to prevent unnecessary dependence on `Report`.
    /// In my understanding, this also makes `TextFileManager` more reusable.
    /// </summary>
    internal class TextFileManager
    {
        public void SaveToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        public string LoadFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
