class Verse
{
    private List<Word> _verse;
    private string _rememberVerse;

    public Verse()
    {
        _verse = new List<Word>();
    }

    public void MakeVerse(string verse)
    {
        _rememberVerse = verse;

        string[] words = verse.Split(' ');
        foreach (string word in words)
        {
            Word wordInstance = new Word(word);
            _verse.Add(wordInstance);
        }

    }

    public void HideWord(int numWords)
    {
        Random random = new Random();
        
        for (int i = 0; i < numWords; i++)
        {
            int index;  
            if (AllWordsHidden())
            {
                break;
            }
            do
            {
                index = random.Next(_verse.Count);
            } while (_verse[index].ReturnWord() == "_____");
            
            _verse[index].ReplaceWord();
        }
    }

    // public void HideWords()
    // {
    //     Console.WriteLine("How many words would you like to hide?");
    //     Console.Write("> ");
    //     if (int.TryParse(Console.ReadLine(), out int numWords))
    //     {
    //         for (int i = 0; i < numWords; i++)
    //         {
    //             if (AllWordsHidden())
    //             {
    //                 break;
    //             }
    //             HideWord();
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid input. Please enter a number.");
    //     }
    // }

    public bool AllWordsHidden()
   {
       return _verse.All(word => word.ReturnWord() == "_____");
   }

    public string ReturnVerse()
    {
        string verse = "";
        foreach (Word word in _verse)
        {
            verse += word.ReturnWord() + " ";
        }
        return verse;
    }

    public string RememberVerse()
    {
        return _rememberVerse;
    }
}