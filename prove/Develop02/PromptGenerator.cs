public class PromptGenerator
{
    // ATTRIBUTES
    // A list of prompts (List<string>)
    //      List<string> *name* = new List<string>() {*prompt*, *prompt*}
    // Random class object
    private Random rnd=new Random();
    private List<string> prompts=new List<string>()
    {
    "Who was the most interesting person I interacted with today? ",
    "What was the best part of my day? ", 
    "How did I see the hand of the Lord in my life today? ", 
    "What was the strongest emotion I felt today? ", 
    "If I had one thing I could do over today, what would it be? "
    };



    // METHODS
    // GetPrompt()

    public string GetPrompt()
    {
        return  prompts[rnd.Next(prompts.Count) ];
    }



}