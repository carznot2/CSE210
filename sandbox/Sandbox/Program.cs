using System;
class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();  
        p1._firstName = "Mary";
        p1._lastName = "Smith";
        p1._dealership = "Waterloo Ford";
        p1._email = "frank@waterlooford.com";
        p1._phone = "250-468-3333";
        p1._city = "Westhover";
        p1._region = "BC";

        Person p2 = new Person(); 
        p1._firstName = "Bill";
        p1._lastName = "Brown";
        p1._dealership = "Universal Lincoln";
        p1._email = "bill@wyahoo.com";
        p1._phone = "403-123-1334";
        p1._city = "Calgary";
        p1._region = "Alberta";

        Person p3 = new Person();
        p1._firstName = "Phil";
        p1._lastName = "Johnson";
        p1._dealership = "Team Ford";
        p1._email = "pjohnson@team.com";
        p1._phone = "780-123-1334";
        p1._city = "Edmonton";
        p1._region = "Alberta";

        List<Person> people = new List person();
        people.Add(p1);
        people.Add(p2);
        people.Add(p3);
        
        foreach (Person p in people)

        {
            Console.WriteLine(p._firstName);
        }
} 
} 
} 
}








