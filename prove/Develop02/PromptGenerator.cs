class PromptGenerator
{
    public List<string> _prompts;

    public string GeneratePrompt()
    {
        _prompts = new List<string>();
        _prompts.Add("How was your day?");
        _prompts.Add("What is something new you learned today?");
        _prompts.Add("What are three things you're grateful for today?");
        _prompts.Add("What was the most challenging part of your day?");
        _prompts.Add("Did you accomplish your goals for today? Why or why not?");
        _prompts.Add("What made you feel happy or fulfilled today?");
        _prompts.Add("What is something you would like to improve on tomorrow?");
        _prompts.Add("Who did you spend time with today, and how did it make you feel?");
        _prompts.Add("What is one moment today that you wish to remember?");
        _prompts.Add("How did you handle stress or difficult emotions today?");

        Random randomPrompt = new();
        
        // Generate a random index and select a prompt from the list
        int index = randomPrompt.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];
        return selectedPrompt;
    }
}