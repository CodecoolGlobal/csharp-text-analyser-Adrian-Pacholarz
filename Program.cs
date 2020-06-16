using System;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    class Program
    {
        static void Main(string[] args)
        {
            FileContent fileContent = new FileContent("test2.txt");
            StatisticalAnalysis charAnalysis = new StatisticalAnalysis(fileContent.CharIterator());
            StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(fileContent.WordIterator());
            Console.WriteLine($"Number of characters: {charAnalysis.Size()}");
            //Console.WriteLine($"Number of words: {wordAnalysis.Size()}");
            Console.WriteLine($"Count of word 'music': {wordAnalysis.CountOf("music")}");

        }
    }
}
