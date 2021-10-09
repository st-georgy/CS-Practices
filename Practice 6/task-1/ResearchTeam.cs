using System;
using static task_1.Program;

namespace task_1
{
    class ResearchTeam
    {
        private string researchTitle;
        private string organization;
        private int regNumber;
        private TimeFrame duration;
        private Paper[] papers;

        public string ResearchTitle { get; private set; }
        public string Organization { get; private set; }
        public int RegNumber { get; private set; }
        public TimeFrame Duration { get; private set; }
        public Paper[] Papers { get; private set; }

        /// <summary>
        /// ResearchTeam Constructor to initialize all fields of the class
        /// </summary>
        /// <param name="researchTitle">Research Title</param>
        /// <param name="organization">Research Organization</param>
        /// <param name="regNumber">Registration Number</param>
        /// <param name="duration">Research Duration</param>
        /// <param name="papers">List of papers</param>
        public ResearchTeam(string researchTitle, string organization, int regNumber, TimeFrame duration, Paper[] papers)
        {
            this.researchTitle = researchTitle;
            this.organization = organization;
            this.regNumber = regNumber;
            this.duration = duration;
            this.papers = papers;
        }

        /// <summary>
        /// Returns Latest paper OR null if list is empty
        /// </summary>
        public Paper latestPaper => papers.Length > 0 ? papers[papers.Length - 1] : null;

        public bool this[TimeFrame frame] => duration == frame;

        /*public void AddPapers(params Paper[])
        {
            
        }*/

        /// <summary>
        /// Overrided virtual ToString() method
        /// </summary>
        /// <returns>String which contains all the class fields</returns>
        public override string ToString()
        {
            string res = $"Title: {researchTitle}\nOrganization: {organization}\nRegistration Number: {regNumber}" +
                $"\nResearch Duration: {duration}\nResearch papers:";
            if (papers.Length == 0)
                res += "\nNone";
            else
                foreach (Paper paper in papers)
                    res += $"\n{paper}";
            return res;
        }

        /// <returns>String which contains all the class fields EXCEPT papers list</returns>
        public virtual string ToShortString() => $"Title: {researchTitle}\nOrganization: {organization}" +
            $"\nRegistration Number: {regNumber}\nResearch Duration: {duration}";
    }
}
