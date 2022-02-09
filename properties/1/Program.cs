
using System;
using Person;

class TimePeriod
{
   private double _seconds;

   public double Hours
   {
       get { return _seconds / 3600; }
       set {
          if (value < 0 || value > 24)
             throw new ArgumentOutOfRangeException(
                   $"{nameof(value)} must be between 0 and 24.");

          _seconds = value * 3600;
       }
   }
}

class Program
{
   static public void Main()
   {
      //  Properties with Backing fields
       TimePeriod t = new TimePeriod();
       // The property assignment causes the 'set' accessor to be called.
       t.Hours = 1;

       // Retrieving the property causes the 'get' accessor to be called.
       Console.WriteLine($"Time in hours: {t.Hours}");


    // Expression body definitions
        Console.WriteLine("ENter your first name : ");
        string fname = Console.ReadLine();
         Console.WriteLine("ENter your last name : ");
        string lname = Console.ReadLine();
        var person = new Person.Person(fname, lname);
        Console.WriteLine(person.Name);

   //
   }
}
