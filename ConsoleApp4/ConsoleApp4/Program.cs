namespace FileInfo_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var newFolderPath = Path.Combine(desktopPath, "new test folder");
            Directory.CreateDirectory(newFolderPath);

            var currentDate = DateTime.Now.ToString("M");

            var dateFolderPath = Path.Combine(newFolderPath, currentDate);
            Directory.CreateDirectory(dateFolderPath);

            var newFilePath = dateFolderPath + "\\new file.txt";
           
            File.WriteAllText(newFilePath, "test");

        }
    }
}