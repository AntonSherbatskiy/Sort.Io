using System.Diagnostics;

namespace Sort.Io
{
    //Static class to interaction with txt file
    internal static class Logger
    {
        #region Methods
        //Write information about sorting
        public static void Write(SortingEngine engine, string fileName)
        {
            using (var writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine($"Date: {DateTime.Now,-22}" +
                    $"Sort type: {engine.SortType,-11}" +
                    $"Array size: {engine.Count,-8}" +
                    $"Comparisons: {engine.Comparisons,-9}" +
                    $"Swaps: {engine.Swaps,-9}" +
                    $"Elapsed time(ms): {engine.ElapsedMilliseconds, -8}" + 
                    $"Delay: {engine.Delay}");
            }
        }

        //Open txt file in notepad.exe
        public static void Open(string fileName)
        {
            Process process = new();
            process.StartInfo.FileName = "notepad.exe";
            process.StartInfo.Arguments = fileName;
            process.Start();
            process.WaitForExit();
        }

        //Delete the contents of txt file
        public static void Clear(string fileName) =>
            File.WriteAllText(fileName, string.Empty);
        #endregion
    }
}