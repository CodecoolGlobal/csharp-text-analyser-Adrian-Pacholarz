using System;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    class Program
    {
        static void Main(string[] args)
        {
            FileContent fileContent = new FileContent("test_dickens_great.txt");
            Iterator charIterator = new CharIterator(fileContent);
            StatisticalAnalysis analysis = new StatisticalAnalysis(charIterator);
            Console.WriteLine(analysis.CharCount());
        }
    }
}
