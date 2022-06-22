namespace Algorithms_and_Data_Structure;

public class GetDirAndFile
{
    public static string DataFileDir = @"C:\Users\rexxr\Documents\tutses\Algorithms and Data Structure\data";

    public static FileInfo[]? GetFilesInDir()
    {
        Directory.SetCurrentDirectory(DataFileDir);
        var di = new DirectoryInfo(Directory.GetCurrentDirectory());
        var fileNames = di.GetFiles("*.*");

        return fileNames;
    }

    public static string[]? ReadFile(string filename)
    {
        var lines = Array.Empty<string>();
        var files = GetFilesInDir();
        var filePath = DataFileDir;

        foreach (var f in files)
            if (f.ToString() == filePath + @"\" + filename)
                lines = File.ReadAllLines(f.ToString());
        return lines;
    }
}