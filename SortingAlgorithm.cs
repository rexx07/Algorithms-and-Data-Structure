/*In given text file, print the words with their frequency. Now print the kth
word in term of frequency.
    Hint:- 
    a) First solution may be you can use the sorting and return the kth
element.
    b) Second solution: You can use the kth element quick select
algorithm.
    c) Third solution: You can use Hashtable or Trie to keep track of the
frequency. Use Heap to get the Kth element.*/

namespace Algorithms_and_Data_Structure;

public class SortingAlgorithm
{
    public void FindWordCount()
    {
        var lines = GetDirAndFile.ReadFile("StringText.txt");
        var wordCountTrack = new Dictionary<string, int>();

        foreach (var line in lines)
        {
            var words = line.Split(" ");
            var wordCount = 0;

            for (var i = 0; i < words.Length - 1; i++)
                if (wordCountTrack.TryGetValue(words[i], out wordCount))
                    wordCountTrack[words[i]] += 1;
                else
                    wordCountTrack.Add(words[i], 1);
        }


        foreach (var word in wordCountTrack) Console.WriteLine(word.Key + " -------------- " + word.Value);
    }
}