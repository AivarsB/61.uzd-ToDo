using System;
using System.Collections.Generic;
using System.Linq;

namespace _61.uzd_ToDo
{
    class Program
    {

        static void Main(string[] args)
        {
            // Izveidot sarakstu, kurā glabāsies visi ToDo ieraksti. 
            // Pievienot šim sarakstam vairākus ToDo ierakstus.

            var todo = new List<ToDo>
            {
                new ToDo()
                {
                    Name = "Car",
                    Description = "Buy car from shop",
                    WeekDay = WeekDayEnum.Monday,
                    Done = true
                },
                new ToDo()
                {
                    Name = "Bike",
                    Description = "Buy bike from private person",
                    WeekDay = WeekDayEnum.Thursday,
                    Done = false
                },
                new ToDo()
                {
                    Name = "Food",
                    Description = "Buy food",
                    WeekDay = WeekDayEnum.Saturday,
                    Done = false
                },
                new ToDo()
                {
                    Name = "Market",
                    Description = "Sell something",
                    WeekDay = WeekDayEnum.Sunday,
                    Done = true
                },
            };

            // Izmantojot LINQ atrast visus ierakstus kuri vēl nav padarīt. 

            var jobsToDo = todo.Where(a => a.Done == false).ToList();

            foreach (var jobToDo in jobsToDo)
            {
                Console.WriteLine($"Jobs to do: {jobToDo.Description} {jobToDo.WeekDay}");
            }

            // Izmantojot LINQ atrast visus ierakstus, kuri jāizdara konkrētā nedēļas dienā.

            var jobsOnSunday = todo.Where(a => a.WeekDay == WeekDayEnum.Sunday).ToList();

            foreach (var jobOnSunday in jobsOnSunday)
            {
                Console.WriteLine($"Jobs on sunday: {jobOnSunday.Description} {jobOnSunday.WeekDay}");
            }
        }
    }
}
// Izveidot jaunu enum (WeekDayEnum), nedēļas dienām. 
// Izveidot jaunu klasi ToDo, kurā ir proprties: Name, Description, WeekDay (šis properties ir ar datu tipu WeekDayEnum), Done (bool). 
// Izveidot sarakstu, kurā glabāsies visi ToDo ieraksti. 
// Pievienot šim sarakstam vairākus ToDo ierakstus.
// Izmantojot LINQ atrast visus ierakstus kuri vēl nav padarīt. 
// Izmantojot LINQ atrast visus ierakstus, kuri jāizdara konkrētā nedēļas dienā.