using System;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            foreach(string arg in args)
            {
                FileContent fileContent = new FileContent(arg);
                if(fileContent.IsFileLoaded())
                {
                    Console.WriteLine(fileContent.GetFileName());
                    StatisticalAnalysis charAnalysis = new StatisticalAnalysis(fileContent.CharIterator());
                    StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(fileContent.WordIterator());
                    Console.WriteLine($"Number of characters: {charAnalysis.Size()}");
                    Console.WriteLine($"Number of words: {wordAnalysis.Size()}");
                    Console.WriteLine($"Dictionary size is: {wordAnalysis.DictionarySize()}");
                    Console.WriteLine($"Count of word 'music': {wordAnalysis.CountOf("music")}");
                    //var occurance = wordAnalysis.OccurMoreThan(5);
                    //foreach(string word in occurance)
                    //{
                    //    Console.WriteLine(word);
                    //}
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine($"Benchmark: {DateTime.Now - start}");

        }
    }
}
