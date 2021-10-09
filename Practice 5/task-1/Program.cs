﻿using System;
using System.IO;
using System.Xml.Serialization;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Person p = Deserialize();
                Console.WriteLine(p.ToString());
            }
            else
            {
                try
                {
                    if (args.Length != 4)
                        throw new ArgumentException("You must provide four arguments.");

                    DateTime dob = new DateTime(Int32.Parse(args[1]), Int32.Parse(args[2]), Int32.Parse(args[3]));
                    Person p = new Person(args[0], dob);
                    Console.WriteLine(p.ToString());

                    Serialize(p);
                }
                catch (Exception ex)
                {
                    DisplayUsageInformation(ex.Message);
                }
            }
        }

        private static void DisplayUsageInformation(string message)
        {
            Console.WriteLine("\nERROR: Invalid parameters. " + message);
            Console.WriteLine("\ntask-1 \"Name\" Year Month Date");
            Console.WriteLine("\nFor example:\ntask-1 \"Tony\" 1922 11 22");
            Console.WriteLine("\nOr, run the command with no arguments to display that previous person.");
        }

        private static void Serialize(Person sp)
        {
            //FileStream fs = new FileStream("Person.Dat", FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, sp);

            FileStream fs = new FileStream("Person.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            xs.Serialize(fs, sp);

            fs.Close();
        }

        private static Person Deserialize()
        {
            Person dsp = new Person();
            //FileStream fs = new FileStream("Person.Dat", FileMode.Open);
            //BinaryFormatter bf = new BinaryFormatter
            //dsp = (Person)bf.Deserialize(fs);

            FileStream fs = new FileStream("Person.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Person));

            dsp = (Person)xs.Deserialize(fs);

            fs.Close();

            return dsp;
        }
    }
}
