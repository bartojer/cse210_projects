using System.IO;

class Menu
{
    public int _totalPoints = 0;
    // private string _shopFile = "shop.txt";
    private List<Goal> _goalList;

    public Menu()
    {
        _goalList = new List<Goal>();
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following options:\n");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record completion");
        Console.WriteLine("6. QUIT");
        Console.Write("> ");
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Numbered");
        Console.WriteLine("3. Eternal");
        // Console.WriteLine("4. Checklist");
        Console.Write("> ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":   // Simple
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string description = Console.ReadLine();
                Console.Write("Enter point value: ");
                int pointValue = int.Parse(Console.ReadLine());
                Console.WriteLine($"Preview: {name} - {description} - {pointValue} points.");
                Console.Write("Is this correct? (y/n): ");

                if (Console.ReadLine().ToLower() == "y")
                {
                    _goalList.Add(new Simple(name, description, pointValue, " "));
                }
                break;

            case "2":   // Numbered
                Console.Write("Enter goal name: ");
                name = Console.ReadLine();
                Console.Write("Enter goal description: ");
                description = Console.ReadLine();
                Console.Write("Enter point value: ");
                pointValue = int.Parse(Console.ReadLine());
                Console.Write("How many times would you like to complete this activity?: ");
                int totalChecks = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing this activity: ");
                int bonus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Preview: {name} - {description} - {pointValue} points.");
                Console.WriteLine($"After completing this {totalChecks} times, you will recieve {bonus} bonus points.");
                Console.Write("Is this correct? (y/n): ");

                if (Console.ReadLine().ToLower() == "y")
                {
                    _goalList.Add(new Numbered(name, description, pointValue, " ", 0, totalChecks, bonus));
                }
                break;

            case "3":   // Eternal
                Console.Write("Enter goal name: ");
                name = Console.ReadLine();
                Console.Write("Enter goal description: ");
                description = Console.ReadLine();
                Console.Write("Enter point value: ");
                pointValue = int.Parse(Console.ReadLine());
                Console.WriteLine($"Preview: {name} - {description} - {pointValue} points.");
                Console.Write("Is this correct? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    _goalList.Add(new Eternal(name, description, pointValue, 0));
                }
                break;
        }
    }
    public void ListGoals()
    {
        if (0 >= _goalList.Count)
        {
            Console.WriteLine("No goals to display");
            return;
        }
        for (int i = 0; i < _goalList.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goalList[i].Display();
        }
    }
    public void SaveGoals(string fileName = "goals.txt")
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(_totalPoints);

                foreach (Goal goal in _goalList)
                {
                    writer.WriteLine(goal.Save());
                }
            }
            Console.WriteLine($"Goals saved to {fileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }
    public void Record()
    {
        Console.WriteLine("Which goal did you complete?");
        ListGoals();
        Console.Write("> ");
        int choice = int.Parse(Console.ReadLine());

        _totalPoints += _goalList[choice - 1].Record();
        Console.WriteLine("Recorded");
    }
    public void LoadFromFile(string fileName = "goals.txt")
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File {fileName} not found.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(fileName);
            if (lines.Length > 0)
            {
                _totalPoints = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(",").Select(p => p.Trim()).ToArray();
                    
                    switch (parts[0].ToLower())
                    {
                        case "simple":
                            _goalList.Add(new Simple(parts[1], parts[2], int.Parse(parts[3]), parts[4]));
                            break;
                        
                        case "numbered":
                            _goalList.Add(new Numbered(
                                parts[1], 
                                parts[2], 
                                int.Parse(parts[3]), 
                                parts[4],
                                int.Parse(parts[5]), // timesCompleted
                                int.Parse(parts[6]), // targetCount
                                int.Parse(parts[7])  // bonus
                            ));
                            break;
                        
                        case "eternal":
                            _goalList.Add(new Eternal(
                                parts[1],
                                parts[2],
                                int.Parse(parts[3]),
                                int.Parse(parts[4]) // completionCount
                            ));
                            break;
                    }
                // Console.WriteLine("Goals loaded successfully.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}
