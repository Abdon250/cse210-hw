class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string reference, string words)
    {
        _words = new List<Word>();
        _reference = new Reference();

        _reference.SetBook(1);
        _reference.SetChapter(1);
        _reference.SetInitialVerse(1);
        _reference.SetFinalVerse((words.Split(' ').Length - 1).ToString());

        string[] wordArray = words.Split(' ');

        for (int i = 0; i < wordArray.Length; i++)
        {
            Word word = new Word(wordArray[i]);
            _words.Add(word);
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"Scripture Reference: {_reference.GetReference()}\n");

        foreach (Word word in _words)
        {
            Console.Write(word.GetContent() + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWord()
{
    List<Word> visibleWords = _words.FindAll(word => word.GetStatus() == false);

    if (visibleWords.Count == 0)
    {
        Console.WriteLine("All words in the scripture are hidden.");
        return;
    }

    Random random = new Random();
    int randomIndex = random.Next(visibleWords.Count);
    Word wordToHide = visibleWords[randomIndex];
    wordToHide.SetStatus(true);
}

}