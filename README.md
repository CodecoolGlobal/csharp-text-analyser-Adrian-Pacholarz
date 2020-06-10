# Text Analyser
Tool for lexical analysis of text data

## Sample output
`---text1.tx--- `    name of the analyzed file

`Char count: 761674`  number of characters in the file (without white-spaces)

`Word count: 188912`  number of words in the file

`Dict size: 10762`  dictionary size: number of different words used

`Most used words (>1%): [a,and,had..<more>]` all words that make up for more than 1% of the text

`'love' count: 60` number of times that the word ‘love’ occurred

`'hate' count: 4` number of times that the word ‘hate’ occurred**

`'music' count: 4` number of times that the word ‘music’ occurred

`vowels %: 38` what part of all characters are vowels (a,o,i,e,u)

`a:e count ratio: 1.54 ` the ratio of ‘a’ to ‘e’ occurrences

`[ G -> 2.16] [ R -> 5.36] ....<and the rest>` % of in whole text of all the letters

# Requirements
1. The main goal is to implement all classes exactly how they're presented in the class diagram. Please, analyse it carefully multiple times and make sure that your implementation is compatibly with it at the end.
2. Don't focus to much on the validity of your results. For now, the software design is your priority,
3. Remember about different kind access modifiers. Small tip: you need to use the default access modifier to implement the code according to the UML class diagram.
4. Private methods are not shown on the diagram. You are free to implement any necessary/helpful private methods in any class.
5. Create custom implementation of iterator pattern.
6. **The input files will only consist of alphabetic characters and white spaces.**
7. The input file will consist both upper and lower case characters. You should use only one case to ensure that the results of the analysis will be consistent.
8. Handle only those exceptions which are required to be handled by the functions and methods you use.
9. The structure of namespaces is not restricted by anything but clean code principles.
10. Don't think too much about the idea of interfaces. Just do it. We'll discuss  this topic later.

# Description


##  IterableText 
 It's an interface. Create the interface with required methods signuteres.

## FileContent
class responsible for reading text files and providing its content through implementing **IterableText ** interface. The content will be provided through methods **CharIterator() ** and **WordIterator().**

## CharIterator
 successively iterates over alphabetic characters (single letters) of the text. It skips all other characters (like white-spaces). Implements MoveNext() and HasNext() from **Iterator ** interface. NOTE: Chars are represented as Strings for the sake of simplicity. Remember that characters’ case (UPPER or lower) should be consistent in our analysis.

## WordIterator
successively iterates over words of the text. Words in the text are separated with white-spaces. Implements MoveNext() and HasNext() from **Iterator ** interface.

## StatisticalAnalysis
It's the dataset. It is initialized with Iterator< and provides functions for statistical analysis of the text elements (Strings). NOTE: You may choose any data structure to store the processed data. The choice will affect the amount of code you will have to write.

### countOf(params string[] elems) 
Returns sum of all occurrences (in the dataset) of the elements given as arguments ( _elems)_. Note: One string may be given as well. NOTE: To clarify - read how params keyword works 



### DictionarySize() 
Returns the number of unique elements of the dataset. It’s the size so-called Author’s Dictionary - the set of different words the author of the text uses.

### Size() 
Returns the total number of all elements in the dataset. This will be total number of words or total number of characters.

### OccurMoreThan(Integer _n_ )
 Returns all the elements that occur more than _n __times _ in the dataset

## View 
This class should be responsible for presenting the data to the user. You are free to implement any functions you find sensible. NOTE: In case of this class you don’t have to follow the UML diagram.

## Application 
The Main class of the program. It should allow the user to pass to text files for analysis as CLI arguments. Also, measure  the time of the program's execution. For example:

>dotnet run -- text1.txt text2.txt
