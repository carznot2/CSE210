using System;
class Program
{
    static void Main()
    {
        Vehicle Ford = new Vehicle();  
        Ford._color="Red";
        Ford._maxSpeed=170;
        Ford.DisplayInfo("F150");  
    }
}