namespace csharp_text_analyser_Adrian_Pacholarz
{
    public interface IterableText
    {
        Iterator CharIterator();

        Iterator WordIterator();

    }
}