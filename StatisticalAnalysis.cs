using System.Collections.Generic;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    class StatisticalAnalysis
    {
        private Iterator _iterator;
        public StatisticalAnalysis(Iterator iterator)
        {
            this._iterator = iterator;

        }

        public int CharCount()
        {
            int CharCount = 0;
            while(_iterator.HasNext())
            {
                _iterator.MoveNext();
                CharCount += 1;
            }

            return CharCount;
        }

        public int CountOf(params string[] elems)
        {
            throw new System.NotImplementedException();
        }

        public int DictionarySize()
        {
            throw new System.NotImplementedException();
        }

        public int Size()
        {
            throw new System.NotImplementedException();
        }

        public ISet<string> OccurMoreThan(int number)
        {
            throw new System.NotImplementedException();
        }

    }
}
