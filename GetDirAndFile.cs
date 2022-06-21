using System.Security.Cryptography.X509Certificates;

namespace Algorithms_and_Data_Structure;

public static class GetDirAndFile
{
    public static string DataFileDir = @"C:\Users\rexxr\Documents\tutses\Algorithms and Data Structure\data";
    
    public static FileInfo[] GetFilesInDir()
    {
        Directory.SetCurrentDirectory(DataFileDir);
        DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
        FileInfo[] fileNames = di.GetFiles("*.*");

        return fileNames;
    }
    
    public static string[] ReadFile(string filename)
    {
        string[] lines = null;
        //string file = filename; //"StringTxt.txt";
        FileInfo[] files = GetFilesInDir();

        foreach (var f in files)
        {
            if (f.ToString() == filename)
            {
                var filePath = DataFileDir;
                lines = File.ReadAllLines(filePath + f);
            }
        }
        
        return lines;
    } 
}   