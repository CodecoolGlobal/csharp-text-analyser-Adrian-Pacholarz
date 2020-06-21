using Xunit;
using System.Collections.Generic;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    public class TestClass
    {
        private string _testFilePath = "/home/shaman/Documents/Codecool/Projects/C#/csharp-text-analyser-Adrian-Pacholarz/test.txt";
        private string _testFilePath2 = "/home/shaman/Documents/Codecool/Projects/C#/csharp-text-analyser-Adrian-Pacholarz/test2.txt";

        [Fact]

        public void CharSizeTest()
        {
            StatisticalAnalysis charAnalysis = new StatisticalAnalysis(new FileContent(_testFilePath).CharIterator());
            StatisticalAnalysis charAnalysis2 = new StatisticalAnalysis(new FileContent(_testFilePath2).CharIterator());

            Assert.Equal(1031, charAnalysis.Size());
            Assert.Equal(939, charAnalysis2.Size());

        }
        
        [Fact]
        public void WordSizeTest()
        {
            StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(new FileContent(_testFilePath).WordIterator());
            StatisticalAnalysis wordAnalysis2 = new StatisticalAnalysis(new FileContent(_testFilePath2).WordIterator());

            Assert.Equal(268, wordAnalysis.Size());
            Assert.Equal(235, wordAnalysis2.Size());


        }
        
        [Fact]
        public void MostUsedTest()
        {
            StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(new FileContent(_testFilePath).WordIterator());
            StatisticalAnalysis wordAnalysis2 = new StatisticalAnalysis(new FileContent(_testFilePath2).WordIterator());

            var expected = new List<string>{"a","and","as","been","but","figure","had","i","in","is","it","me","music","no","not","of","old","the","to","was","where"};

            Assert.Equal(expected, wordAnalysis.MostUsedElements());
            
        }
    }
}