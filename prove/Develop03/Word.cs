class Word
{
    private string _word;

    public void ReplaceWord()
    {
        _word = "_____";
    }

    public string ReturnWord()
    {
        return _word;
    }

    public Word(string word)
    {
        _word = word;
    }
}