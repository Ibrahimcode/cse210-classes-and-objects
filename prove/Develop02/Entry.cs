class EntryData
{
    public string date {get; set;}
    public string promptText {get; set;}
    public string entryText {get; set; }
}

class Entry
{
    // Holds the data enter by the user.
    public EntryData entryData = new EntryData(); 

    public Entry(EntryData entryData)
    {
        this.entryData = entryData;
    }

    // Display a single entry.
    public void Display()
    {
        Console.WriteLine($"Date: {this.entryData.date} - Prompt: {this.entryData.promptText}");
        Console.WriteLine($"{this.entryData.entryText}");
        Console.WriteLine();
    }
}