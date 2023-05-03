public class Vehicle
{
    public bool _chassis=true;
    public string _color;

    public int _maxSpeed;
    //  constructor here
    public void DisplayInfo(string name) 
    {   
        string chassis = "";
        if(_chassis==true ) 
        {
            chassis="full";
        
        }
        else
        {
            chassis="sub";
        }
        
        Console.WriteLine ($"The vehicle named {name} is {_color} with a max speed of {_maxSpeed} and has a {chassis} chassis.");
      
    }



}