class Reflect : Activity{

    private int _questionCount = 2;
    public Reflect(){
        _name = "reflecting";
        _verb = "reflect";
        _description = "Thank you for joining me for a reflection session. Prepare to discover the unknown depths of your mind";
        _questionCount = 2;
    }
    private readonly List<string> _prompts = ["Think of a time you did something difficult", "Think of a time you did something you had been trying to do for a long time", "Think about those who have helped you", "Think about those you have helped", "Think about a time you were kind to someone", "Think about a time someone was kind to you", "Think about a time you were proud of yourself", "Think about a time you were proud of someone else", "Think about a time you learned something new", "Think about a time you taught someone something new"];

    private readonly List<string> _questions = ["What did you learn from this experience?", "What would you do differently next time?", "How has this experience changed the way you see yourself?", "How has this experience changed the way you view the world and those around you?"];

    private void QuestionCount()
    {
        if (_duration > 30)
        {
            _questionCount = 3;
        }
    }

    public string GetPrompt()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        
        return $" --- {_prompts[i]} ---";
    }

    public string GetQuestion()
    {
        Random random = new Random();
        int i = random.Next(0, _questions.Count);
        return $"\n{_questions[i]}\n";
    }

    public void RunReflection()
    {
        Console.Clear();

        Spinner spinner = new Spinner();
        QuestionCount();

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine(GetPrompt());

        Console.WriteLine("\nWhen you have thought of something, press enter to continue");
        Console.ReadLine();
        
        Console.Write($"Take some time to ponder the following {_questionCount} questions ");
        Console.Write("Begin in ");
        CountDown(5);

        int segments = _duration / _questionCount;

        for (int i = 0; i < _questionCount; i++)
        {
            Console.WriteLine(GetQuestion());
            spinner.Spin(segments);
        }
    }

}