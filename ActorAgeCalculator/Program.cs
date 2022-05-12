using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ActorAgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Мартин\Desktop\Interview Tasks\ActorAgeCalculator\input.txt");

            List<MovieStar> items = JsonConvert.DeserializeObject<List<MovieStar>>(text);

            foreach (var item in items)
            {
                var yearsOld = (DateTime.Today.Subtract(item.DateOfBirth)).TotalDays / 365.2425;
                Console.WriteLine("{0} {1} {2} {3} {4} \n", item.Name,item.Surname + "\n",item.Nationality +"\n",item.Sex + "\n", $"Is {Math.Round(yearsOld)} years old !" );
            }
        }

    }
}
