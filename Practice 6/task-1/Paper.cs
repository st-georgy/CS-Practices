using System;

namespace task_1
{
    class Paper
    {
        public string papTitle { get; private set; }
        public Person papAuthor { get; private set; }
        public DateTime papDate { get; private set; }

        /// <summary>
        /// Paper Constructor to initialize all fields of the class
        /// </summary>
        /// <param name="papTitle">Paper Title</param>
        /// <param name="papAuthor">Paper Author</param>
        /// <param name="papDate">Paper publication Date</param>
        public Paper(string papTitle, Person papAuthor, DateTime papDate)
        {
            this.papTitle = papTitle;
            this.papAuthor = papAuthor;
            this.papDate = papDate;
        }

        /// <summary>
        /// Person Constructor with basic values
        /// </summary>
        public Paper() : this("Title", new Person(), DateTime.MinValue) {}

        /// <summary>
        /// Overrided virtual ToString() method
        /// </summary>
        /// <returns>String which contains all the class fields</returns>
        public override string ToString() => $"{papTitle} by {papAuthor} ({papDate})";
    }
}
