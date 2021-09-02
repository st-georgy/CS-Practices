using System;

namespace task_1
{
    class Program
    {
        public enum Genders : int { Male, Female };

        struct Person
        {
            public string firstName;
            public string lastName;
            public int age;
            public Genders gender;

            public Person(string _firstName, string _lastName, int _age, Genders _gender)
            {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                gender = _gender;
            }

            public override string ToString()
            {
                return $"{firstName} {lastName} ({gender.ToString()[0]}), {age}";
            }

        }

        static void Main(string[] args)
        {
            Person p = new Person("Georgy", "Zhidkov", 18, Genders.Male);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
