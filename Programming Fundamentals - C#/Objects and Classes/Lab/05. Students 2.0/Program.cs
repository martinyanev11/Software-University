using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                string homeTown = cmdArgs[3];

                Student currentStudent = new Student();
                currentStudent.FirstName = firstName;
                currentStudent.LastName = lastName;
                currentStudent.Age = age;
                currentStudent.HomeTown = homeTown;

                if (isStudentListed(studentsList, firstName, lastName))
                {
                    Student replacementStudent = StudentToReplace(studentsList, firstName, lastName);

                    replacementStudent.Age = age;
                    replacementStudent.HomeTown = homeTown;
                }
                else
                {
                    studentsList.Add(currentStudent);
                }

            }

            string printOnlyFromThisCityName = Console.ReadLine();
            foreach (Student student in studentsList)
            {
                if (student.HomeTown == printOnlyFromThisCityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        // This method knows there are 2 students with the same name, and looks again, then send the object "student"
        // back to main method (so basically i don't return the index of the object but the entire object)!
        // This method and the one below could potentially be merged into one because of code repetition!
        static Student StudentToReplace(List<Student> studentsList, string firstName, string lastName)
        {
            foreach (Student student in studentsList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }

        static bool isStudentListed(List<Student> studentsList, string firstName, string lastName)
        {
            foreach (Student student in studentsList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
