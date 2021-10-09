using System;
using System.Runtime.Serialization;

namespace task_1
{
    [Serializable]
    public class Person : IDeserializationCallback
    {
        public string name;
        public DateTime dateOfBirth;
        /* [NonSerialized] */ public int age;

        public Person(string _name, DateTime _dateOfBirth)
        {
            name = _name;
            dateOfBirth = _dateOfBirth;
            CalculateAge();
        }

        public Person() {}

        public override string ToString()
        {
            return name + " was born on " + dateOfBirth.ToShortDateString() + " and is " + age.ToString() + " years old.";
        }

        private void CalculateAge()
        {
            age = DateTime.Now.Year - dateOfBirth.Year;

            if (dateOfBirth.AddYears(DateTime.Now.Year - dateOfBirth.Year) > DateTime.Now)
                age--;
        }

        public void OnDeserialization(object sender)
        {
            CalculateAge();
        }
    }
}
