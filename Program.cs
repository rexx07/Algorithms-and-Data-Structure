// See https://aka.ms/new-console-template for more information

using Algorithms_and_Data_Structure;

string[] files = GetDirAndFile.ReadFile("StringText.txt");
foreach (var line in files)
{
    Console.WriteLine(line);
}

