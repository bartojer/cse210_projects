class Reference
{
    private string _reference;

    public Reference(string book, int chapter, int verse)
    {
        _reference = book + " " + chapter + ":" + verse;
    }

    public Reference(string book, string chapter, int start_verse, int end_verse)
    {
        _reference = book + " " + chapter + ":" + start_verse + "-" + end_verse;
    }



    public string ReturnReference()
    {
        return _reference;
    }
}