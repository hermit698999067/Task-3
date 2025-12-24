using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    enum StudyForm
    {
        FullTime,
        PartTime
    }

    class Student
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public StudyForm Form { get; set; }

        public Student(string name, int course, StudyForm form)
        {
            Name = name;
            Course = course;
            Form = form;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}, курс {Course}, форма: {Form}");
        }
    }

    class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Group(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            Students.Add(s);
        }

        public void PrintAllStudents()
        {
            Console.WriteLine("Группа: " + Name);
            foreach (Student s in Students)
            {
                s.PrintInfo();
            }
        }

        public (int count, double avgCourse) GetStatistics()
        {
            int count = Students.Count;
            double avgCourse = count > 0 ? Students.Average(s => s.Course) : 0;
            return (count, avgCourse);
        }
    }

    class Program
    {
        static void Main()
        {
            Group group = new Group("П-307");

            group.AddStudent(new Student("Алишер", 1, StudyForm.FullTime));
            group.AddStudent(new Student("Адиль", 2, StudyForm.PartTime));
            group.AddStudent(new Student("Амир", 3, StudyForm.FullTime));

            group.PrintAllStudents();

            var stats = group.GetStatistics();
            Console.WriteLine($"Количество студентов: {stats.count}");
            Console.WriteLine($"Средний курс: {stats.avgCourse:F2}");
        }
    }
}
