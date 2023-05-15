public class Journal
{
    // ATTRIBUTES
    // A list to store all of the entries (List<Entry>)
    // FileHandling object
    // (Access Type) (Class Type) (Name) = new (Constructor)
    private List<Entry> entries=new List<Entry>();
    private FileHandling fileHandling=new FileHandling();
    

    // METHODS
    // AddEntry()
    // (Access Type) (Return Type) (Name)
    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.WriteEntry();
        entries.Add(entry);
    }
    // DisplayEntries()
    public void DisplayEntries() 
    {
        foreach(Entry entry in entries)
        {
            Console.WriteLine(entry.Date);
            Console.WriteLine(entry.Prompt);
            Console.WriteLine(entry.Response);
            

        } 
    }
    
    public void Save()
    {
        fileHandling.Save(entries);
    }

    public void Load()
    {
        entries=fileHandling.Load();
    }
}