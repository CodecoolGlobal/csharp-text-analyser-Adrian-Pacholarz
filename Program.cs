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
                    Console.WriteLine($"-----{fileContent.GetFileName()}-----");
                    StatisticalAnalysis charAnalysis = new StatisticalAnalysis(fileContent.CharIterator());
                    StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(fileContent.WordIterator());
                    charAnalysis.View.Print("Number of characters", charAnalysis.Size());
                    wordAnalysis.View.Print("Number of words", wordAnalysis.Size());
                    wordAnalysis.View.Print("Dictionary size", wordAnalysis.DictionarySize());
                    wordAnalysis.View.Print("Most used words (>1%)", wordAnalysis.MostUsedElements());
                    wordAnalysis.View.Print("Count of word 'love'", wordAnalysis.CountOf("love"));
                    wordAnalysis.View.Print("Count of word 'hate'", wordAnalysis.CountOf("hate"));
                    wordAnalysis.View.Print("Count of word 'music'", wordAnalysis.CountOf("music"));
                    charAnalysis.View.Print("Vowels %", charAnalysis.VowelsPercentage());
                    charAnalysis.View.Print("a:e count ratio", charAnalysis.Ratio("a", "e"));
                    charAnalysis.View.Print(charAnalysis.ElementOccurance());
                    //wordAnalysis.View.Print(wordAnalysis.OccurMoreThan(5));
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine($"Benchmark: {DateTime.Now - start}");

        }
    }
}
