namespace PayslipCSV
{
    public class CsvWriter
    {
        public string Path { get; }

        public CsvWriter(string path)
        {
            Path = path;
        }
    }
}