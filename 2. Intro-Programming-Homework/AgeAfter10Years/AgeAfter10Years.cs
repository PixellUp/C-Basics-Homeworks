using System;

class AgeAfter10Years
{
   
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        DateTime bday = Convert.ToDateTime(input);

        Console.WriteLine("Now: " + (DateTime.Now.Year - bday.Year));

        Console.WriteLine("After 10 years: " + ((DateTime.Now.Year - bday.Year) + 10));
    }
}

