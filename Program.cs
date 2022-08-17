// See https://aka.ms/new-console-template for more information
using System;
using TestGittHub_Repasitory;
using TestGittHub_Repasitory.Enums;

namespace GitLesson4
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int> { 1, 3, 23, 2313, 2342342, 2342342 };
            var t = numbers.Sum();
            var count = numbers.Count();
            var c = numbers.Where(a => a % 2 == 0).Select(a => $"{a}n zuyg a").ToList();

            var myVar = LevelEnum.Low;
            switch (myVar)
            {
                case LevelEnum.Low:
                    Console.WriteLine($"Your level is {LevelEnum.Low}\n");
                    break;
                case LevelEnum.Medium:
                    Console.WriteLine($"Your level is {LevelEnum.Medium}\n");
                    break;
                case LevelEnum.High:
                    Console.WriteLine($"Your level is {LevelEnum.High}\n");
                    break;
            }

            Person person = new Person()
            {
                Name = "Narek",
                Age = 20,
                Id = "12665",
                DateOfBirth = new DateTime(2001, 11, 06)

            };
         
            Company company = new Company()
            {
                Worker_position = PositionEnum.Manager,
                Working_hours_st = 7.0,
                Working_hours_end = 18.0,
                CreateDate = DateTime.UtcNow,
                Emploee = new List<Employer>()
                {
                    new Employer(),
                    new Employer(),
                    new Employer(),
                }

            };


 
            Console.WriteLine($"Firstname is {person.Name}");
            Console.WriteLine($"Age is {person.Age}");
            Console.WriteLine($"ID: {person.Id}");

            string[] companies = { "ALL", "Ger_mark", "Three_clean", "Germany_Wolswagen_Company" };
            var company_choosee = companies.Where(a => a.StartsWith("G")).ToList();

            foreach (var com in company_choosee)
            {
                Console.WriteLine($"Company is {com}");
            }
            Console.WriteLine($"There are {company.Emploee} employees in this company");
            Console.WriteLine($"Your position is {company.Worker_position}");
            Console.WriteLine($"Work start at {company.Working_hours_st} oclock");
            Console.WriteLine($"Work end at {company.Working_hours_end} oclock");
            Console.WriteLine($"Datetime: {company.CreateDate}");
        }


    }

    
    // public readonly record struct Point(double X,double Y,double Z);




    //enum Mounths
    //{
    //    January,    // 0
    //    February,   // 1
    //    March,      // 2
    //    April=5,      // 3 es depqum 5 ica  hashvum
    //    May,        // 4
    //    June,       // 5
    //    July        // 6
    //}



}
