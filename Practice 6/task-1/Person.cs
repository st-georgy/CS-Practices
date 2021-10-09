using System;

namespace task_1
{
    class Person
    {
        private string name;
        private string surname;
        private DateTime birthDate;

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateTime BirthDate { get; private set; }

        /// <summary>
        /// Getting information and changing the year of birth
        /// </summary>
        public int BirthYear {
            get => birthDate.Year;
            set => new DateTime(value, birthDate.Month, birthDate.Day);
        }

        /// <summary>
        /// Person Constructor to initialize all fields of the class
        /// </summary>
        /// <param name="name">Person Name</param>
        /// <param name="surname">Person Surname</param>
        /// <param name="birthDate">Person Date of Birth</param>
        public Person(string name, string surname, DateTime birthDate)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
        }

        /// <summary>
        /// Person Constructor with basic values
        /// </summary>
        public Person() : this("Ivan", "Ivanov", DateTime.MinValue) {}

        /// <summary>
        /// Overrided virtual ToString() method
        /// </summary>
        /// <returns>String which contains all the class fields</returns>
        public override string ToString() => $"{name} {surname} was born on {birthDate.Date}";

        /// <summary>
        /// Virtual ToShortString() method
        /// </summary>
        /// <returns>String which contains only Name and Surname</returns>
        public virtual string ToShortString() => $"{name} {surname}";
    }
}
