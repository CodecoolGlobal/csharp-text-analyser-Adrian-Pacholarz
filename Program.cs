using System;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach(string arg in args)
            {
                FileContent fileContent = new FileContent(arg);
                StatisticalAnalysis charAnalysis = new StatisticalAnalysis(fileContent.CharIterator());
                StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(fileContent.WordIterator());
                Console.WriteLine($"Number of characters: {charAnalysis.Size()}");
                Console.WriteLine($"Number of words: {wordAnalysis.Size()}");
                Console.WriteLine($"Dictionary size is: {wordAnalysis.DictionarySize()}");
                Console.WriteLine($"Count of word 'music': {wordAnalysis.CountOf("music")}");
                var occurance = wordAnalysis.OccurMoreThan(2);
                foreach(string word in occurance)
                {
                    Console.WriteLine(word);
                }
                
            }

        }
    }
}
