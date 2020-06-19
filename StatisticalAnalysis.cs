using System.Collections.Generic;
using System;

namespace csharp_text_analyser_Adrian_Pacholarz
{
    class StatisticalAnalysis
    {
        private Iterator _iterator;

        public View View = new View();

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

        public Dictionary<string, double> ElementOccurance()
        {
            var elementCount = new Dictionary<string, double>();

            while(_iterator.HasNext())
            {
                string elem =_iterator.MoveNext();
                if (elementCount.ContainsKey(elem))
                {
                    elementCount[elem] += 1;
                }
                else
                {
                    elementCount.Add(elem, 1);
                }
            }

            _iterator.Reset();

            var allElements = this.Size();
            
            foreach (string key in new List<string>(elementCount.Keys))
            {
                elementCount[key] = (elementCount[key] / allElements) * 100;
            }

            return elementCount;            

        }

        public List<string> MostUsedElements()
        {
            var mostUsedElements = new List<string>();
            var elementsOccurance = this.ElementOccurance();

            foreach (string key in elementsOccurance.Keys)
            {
                if (elementsOccurance[key] > 1)
                {
                    mostUsedElements.Add(key);
                }
            }

            return mostUsedElements;
        }

        public int VowelsPercentage()
        {
            List<string> vowels = new List<string>{"a", "o", "i", "e", "u"};
            int vowelsCount = 0;

            while(_iterator.HasNext())
            {
                string elem = _iterator.MoveNext();
                if (vowels.Contains(elem))
                {
                    vowelsCount += 1;
                }

            }
            _iterator.Reset();

            var allElements = this.Size();

            return (vowelsCount * 100) / allElements;

        }

        public double Ratio(string x, string y)
        {
            var elementCount = new Dictionary<string, double>{{x.ToLower(), 0}, {y.ToLower(), 0}};

            while(_iterator.HasNext())
            {
                string elem = _iterator.MoveNext();
                if (elem == x || elem == y)
                {
                    elementCount[elem] += 1;
                }

            }
            _iterator.Reset();

            return (elementCount[x] / elementCount[y]);

        }

    }
    
}
