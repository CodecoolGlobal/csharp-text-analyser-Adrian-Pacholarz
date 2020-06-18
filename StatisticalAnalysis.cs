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
            var dictionaryWords = new List<string>();

            while(_iterator.HasNext())
            {
                string elem =_iterator.MoveNext();
                if(!dictionaryWords.Contains(elem))
                {
                    dictionaryWords.Add(elem);
                }
            }

            _iterator.Reset();

            return dictionaryWords.Count;

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
            var occuranceElems = new SortedSet<string>();
            var dictionaryOfElems = new Dictionary<string, int>();

            while(_iterator.HasNext())
            {
                string elem =_iterator.MoveNext();
                if (dictionaryOfElems.ContainsKey(elem))
                {
                    dictionaryOfElems[elem] += 1;
                }
                else
                {
                    dictionaryOfElems.Add(elem, 1);
                }
            }

            _iterator.Reset();

            foreach (string key in dictionaryOfElems.Keys)
            {
                if(dictionaryOfElems[key] > number)
                {
                    occuranceElems.Add(key);
                }
            }

            return occuranceElems;
        }

    }
}
