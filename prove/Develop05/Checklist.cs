class Checklist : Goal
{
    private List<string> _items;
    private List<bool> _itemStatus;

    public Checklist(string name, string description, int pointValue, List<string> items = null, List<bool> status = null) : base(name, description, pointValue)
    {
        _goalType = "checklist";
        _items = items ?? new List<string>();
        _itemStatus = status ?? new List<bool>();
    }

    public void AddItem(string item)
    {
        _items.Add(item);
        _itemStatus.Add(false);
    }

    public override string Save()
    {
        string itemsList = string.Join("|", _items);
        string statusList = string.Join("|", _itemStatus.Select(b => b ? "1" : "0"));
        return $"{base.Save()}, {itemsList}, {statusList}";
    }

    public override int Record()
    {
        Console.WriteLine("Select item to mark as complete:");
        for (int i = 0; i < _items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. [{(_itemStatus[i] ? "X" : " ")}] {_items[i]}");
        }
        Console.Write("> ");
        int choice = int.Parse(Console.ReadLine()) - 1;
        
        if (choice >= 0 && choice < _items.Count && !_itemStatus[choice])
        {
            _itemStatus[choice] = true;
            return base.Record();
        }
        return 0;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine();
        for (int i = 0; i < _items.Count; i++)
        {
            Console.WriteLine($"   [{(_itemStatus[i] ? "X" : " ")}] {_items[i]}");
        }
    }
}


// case "checklist":
//     // Reconstruct the items and status strings in case they contain commas
//     string itemString = string.Join(",", parts.Skip(4).Take(1));
//     string statusString = parts[parts.Length - 1];
    
//     List<string> items = itemString.Split('|').ToList();
//     List<bool> status = statusString.Split('|').Select(s => s == "1").ToList();
//     _goalList.Add(new Checklist(parts[1], parts[2], int.Parse(parts[3]), items, status));
//     break;

// case "4":   // Checklist
//     Console.Write("Enter goal name: ");
//     name = Console.ReadLine();
//     Console.Write("Enter goal description: ");
//     description = Console.ReadLine();
//     Console.Write("Enter point value per item: ");
//     pointValue = int.Parse(Console.ReadLine());
    
//     Checklist checklist = new Checklist(name, description, pointValue);
    
//     string itemInput = "";
//     Console.WriteLine("Enter checklist items (empty line to finish):");
//     while (true)
//     {
//         Console.Write("> ");
//         itemInput = Console.ReadLine();
//         if (string.IsNullOrWhiteSpace(itemInput)) break;
//         checklist.AddItem(itemInput);
//     }
    
//     _goalList.Add(checklist);
//     break;