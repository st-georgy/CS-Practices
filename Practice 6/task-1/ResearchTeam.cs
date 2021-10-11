using System.Collections.Generic;

namespace task_1
{
    class ResearchTeam
    {
        private string researchTitle;
        private string organization;
        private int regNumber;
        private TimeFrame duration;
        private List<Paper> papers = new List<Paper>();

        public string ResearchTitle { get => researchTitle; set => researchTitle = value; }
        public string Organization { get => organization; set => organization = value; }
        public int RegNumber { get => regNumber; set => regNumber = value; }
        public TimeFrame Duration { get => duration; set => duration = value; }
        public IReadOnlyList<Paper> Papers { get => papers.AsReadOnly(); }

        /// <summary>
        /// ResearchTeam Constructor to initialize all fields of the class
        /// </summary>
        /// <param name="researchTitle">Research Title</param>
        /// <param name="organization">Research Organization</param>
        /// <param name="regNumber">Registration Number</param>
        /// <param name="duration">Research Duration</param>
        /// <param name="papers">List of papers</param>
        public ResearchTeam(string researchTitle, string organization, int regNumber, TimeFrame duration)
        {
            this.researchTitle = researchTitle;
            this.organization = organization;
            this.regNumber = regNumber;
            this.duration = duration;
        }

        public ResearchTeam() : this("Title", "Organization", 29903, TimeFrame.Long) {}

        /// <summary>
        /// Returns Latest paper OR null if list is empty
        /// </summary>
        public Paper latestPaper => papers.Count > 0 ? papers[papers.Count - 1] : null;

        /// <summary>
        /// Boolean indexer (only with get)
        /// </summary>
        /// <param name="frame">Indexer value</param>
        /// <returns>Returns true if the value of the field with research duration info
        /// matches the index value, otherwise returns false</returns>
        public bool this[TimeFrame frame] => duration == frame;

        /// <summary>
        /// Adds range of papers into papers list
        /// </summary>
        /// <param name="paps">List of papers to add</param>
        public void AddPapers(params Paper[] paps) => papers.AddRange(paps);


        /// <summary>
        /// Overrided virtual ToString() method
        /// </summary>
        /// <returns>String which contains all the class fields</returns>
        public override string ToString()
        {
            string res = $"Title: {researchTitle}\nOrganization: {organization}\nRegistration Number: {regNumber}" +
                $"\nResearch Duration: {duration}\nResearch papers:";
            if (papers.Count == 0)
                res += "\nNone";
            else
                foreach (Paper paper in papers)
                    res += $"\n{papers.IndexOf(paper) + 1}. {paper}";
            return res;
        }

        /// <returns>String which contains all the class fields EXCEPT papers list</returns>
        public virtual string ToShortString() => $"Title: {researchTitle}\nOrganization: {organization}" +
            $"\nRegistration Number: {regNumber}\nResearch Duration: {duration}";
    }
}
