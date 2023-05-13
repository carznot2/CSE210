public class Entry
{
    // ATTRIBUTES
    // PromptGenerator object
    // DateTime object
    // prompt
    // response
    // date
    private string prompt;
    private string response;
    private string date;

    public string Prompt
    { 
        get{ return prompt; }
    }
    public string Response
    {
        get{ return response; }
    }
    public string Date 
    {
        get{ return date; }
    }


    // entry.Prompt = "asdf"
    private PromptGenerator promptGenerator = new PromptGenerator();
    private DateTime dateTime=DateTime.Now;

    // METHODS
    public Entry(){}
    public Entry(string date, string prompt, string response)
    {
        this.date = date;
        this.prompt = prompt;
        this.response = response;
    }
    public void WriteEntry()
    {
        date=dateTime.ToShortDateString();
        prompt = promptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        response = Console.ReadLine();
    }
    // WriteEntry()
    // DisplayEntry()
}