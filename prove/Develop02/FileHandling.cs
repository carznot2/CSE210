public class FileHandling
{
    public void Save(List<Entry> entries)
    {
        using(StreamWriter Out = new StreamWriter("Journal.txt", true))
        {
            
            foreach(Entry entry in entries)
            {
                Out.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            } 
        }
    }

    public List<Entry> Load()
    {
        List<Entry> entries = new List<Entry>();
        string filename = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] data = line.Split("|");
            Entry entry = new Entry(data[0], data[1], data[2]);
            entries.Add(entry);
        }
        return entries;
    }
}