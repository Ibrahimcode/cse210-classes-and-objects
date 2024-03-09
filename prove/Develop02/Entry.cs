class EntryData
{
    /***
    * A data model to be save in a file.
    */
    public string date {get; set;}
    public string promptText {get; set;}
    public string entryText {get; set; }
}

class Entry
{
    // Holds the data enter by the user.
    public EntryData _entryData = new EntryData(); 

    public Entry(EntryData entryData)
    {
        this._entryData = entryData;
    }

    // Display a single entry.
    public void Display()
    {
        Console.WriteLine($"Date: {this._entryData.date} - Prompt: {this._entryData.promptText}");
        Console.WriteLine($"{this._entryData.entryText}");
        Console.WriteLine();
    }
}