using System;
using System.Collections.Generic;

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
    }

    class Program
    {
        static void Main()
        {
            Group group = new Group("ПМ-307");

            group.AddStudent(new Student("Амир", 1, StudyForm.FullTime));
            group.AddStudent(new Student("Алишер", 2, StudyForm.PartTime));

            group.PrintAllStudents();
        }
    }
}
