namespace EmployeeFileStorer
{
    public abstract class Department : ITextWriter
    {
        public static void WriteToTextFile(string writeFilePath, string content)
        {
            if (!File.Exists(writeFilePath))
            {
                using (StreamWriter sw = File.CreateText(writeFilePath))
                {
                    sw.WriteLine(content);
                }
            }
        }
    }
}