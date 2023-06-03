class Reference
{
    private int _book;
    private int _chapter;
    private string _finalVerse;
    private int _initialVerse;

    public void SetBook(int book)
    {
        _book = book;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void SetFinalVerse(string finalVerse)
    {
        _finalVerse = finalVerse;
    }

    public void SetInitialVerse(int initialVerse)
    {
        _initialVerse = initialVerse;
    }

    public string GetReference()
    {
        return $"{_book}:{_chapter}:{_initialVerse}-{_finalVerse}";
    }
}
