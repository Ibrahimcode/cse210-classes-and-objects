using System.IO;
using System.Text.Json;

class Journal
{
    List<Entry> _entries = new List<Entry>(); // List of Entries

    List<EntryData> _entryDatum; // Contains only the data entered by the user.

    // Add an entry to the list of journal entries
    public void AddEntry(Entry newEntry)
    {
        this._entries.Add(newEntry);
    }

    // Display all the journal entries.
    public void DisplayAll()
    {
        foreach (Entry entry in this._entries)
        {
            entry.Display();
        }
    }

    // Save all the journal entries to a json file
    public void SaveToFile(string file)
    {
        // Save only the entry properties (data), not methods.
        this._entryDatum = new List<EntryData>();
        foreach (Entry entry in this._entries)
        {
            _entryDatum.Add(entry.entryData);
        }

        using (StreamWriter journalFile = new StreamWriter(file))
        {
            string entryJsonString = JsonSerializer.Serialize(this._entryDatum);
            journalFile.WriteAsync(entryJsonString);
        }
    }

    // Load all journal entries from a json file.
    public void LoadFromFile(string file)
    {
        this._entryDatum = new List<EntryData>();

        using (StreamReader journalFile = new StreamReader(file))
        {
            string entryJsonString = journalFile.ReadToEnd();
            this._entryDatum = JsonSerializer.Deserialize<List<EntryData>>(entryJsonString);
        }

        // Add all journal entry data to the to the list of entries.
        foreach (EntryData entryData in this._entryDatum)
        {
            _entries.Add(new Entry(entryData));
        }
        
    }
}