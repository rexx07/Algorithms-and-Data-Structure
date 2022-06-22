using System.Security.Cryptography.X509Certificates;

namespace Algorithms_and_Data_Structure;

public class GetDirAndFile
{
    public static string DataFileDir = @"C:\Users\rexxr\Documents\tutses\Algorithms and Data Structure\data";
    
    public static FileInfo[]? GetFilesInDir()
    {
        Directory.SetCurrentDirectory(DataFileDir);
        DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
        FileInfo[] fileNames = di.GetFiles("*.*");
        
        return fileNames;
    }
    
    public static string[]? ReadFile(string filename)
    {
        string[]? lines = Array.Empty<string>();
        FileInfo[]? files = GetFilesInDir();
        var filePath = DataFileDir;

        foreach (var f in files)
        {
            if (f.ToString() == filePath + @"\" + filename)
            {
                lines = File.ReadAllLines(f.ToString());
            }
        }
        return lines;
    } 
}   