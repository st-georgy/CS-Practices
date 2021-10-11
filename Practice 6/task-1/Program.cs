using System;

namespace task_1
{
    public enum TimeFrame : int { Year = 1, TwoYears, Long };

    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam rsTeam = new ResearchTeam();
            Console.WriteLine(rsTeam.ToShortString() + "\n");
            Console.WriteLine((int)TimeFrame.Year);
            Console.WriteLine((int)TimeFrame.TwoYears);
            Console.WriteLine((int)TimeFrame.Long + "\n");

            rsTeam.ResearchTitle = "Atlantis";
            rsTeam.Organization = "Stargate";
            rsTeam.RegNumber = 2020;
            rsTeam.Duration = TimeFrame.Long;

            rsTeam.AddPapers(new Paper(), new Paper("Wraith", new Person("John", "Sheppard", new DateTime(1970, 6, 14)), new DateTime(2004, 7, 17)));

            Console.WriteLine(rsTeam + "\n");

            Console.WriteLine("Latest paper:\n" + rsTeam.latestPaper);

            Console.ReadKey();
        }
    }
}
