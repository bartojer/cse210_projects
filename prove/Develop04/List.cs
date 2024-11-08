class List : Activity{
    public List(){
        _name = "listing";
        _verb = "list";
        _description = "List things";
    }

    private List<string> _prompts = ["What are grateful for?", "What are you are looking forward to?", "What are you proud of?"];
    private List<string> _responses = new List<string>();

    public async void Timer(){
        await Task.Delay(_duration * 1000);
        Console.WriteLine("Time's up!");
    }

    public int GetResponseCount(){
        return _responses.Count;
    }

    public void RunListing()
    {
        Console.Clear();

        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        string prompt = _prompts[i];
        Console.WriteLine(prompt);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                _responses.Add(response);
            }
        }

        Console.WriteLine("Time's up!");
        Console.WriteLine($"You listed {_responses.Count} items!");
    }
}