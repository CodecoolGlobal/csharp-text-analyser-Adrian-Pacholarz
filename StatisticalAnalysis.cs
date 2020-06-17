using System.Collections.Generic;
using System;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    class StatisticalAnalysis
    {
        private Iterator _iterator;
        public StatisticalAnalysis(Iterator iterator)
        {
            this._iterator = iterator;

        }

        public int CountOf(params string[] elems)
        {
            int elemCount = 0;

            foreach (string word in elems)
            {
                while(_iterator.HasNext())
                {
                    string elem = _iterator.MoveNext();
                    if (word == elem)
                    {
                        elemCount += 1;
                    }                        
                }
                _iterator.Reset();
                
            }

            return elemCount;
        }

        public int DictionarySize()
        {
            throw new System.NotImplementedException();
        }

        public int Size()
        {
            int elemCount = 0;
            while(_iterator.HasNext())
            {
                _iterator.MoveNext();
                elemCount += 1;
            }

            _iterator.Reset();

            return elemCount;
        }

        public ISet<string> OccurMoreThan(int number)
        {
            throw new System.NotImplementedException();
        }

    }
}
