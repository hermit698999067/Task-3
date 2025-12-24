using System;

class Student
{
    public string Name { get; set; }
    public int Course { get; set; }

    public Student(string name, int course)
    {
        Name = name;
        Course = course;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Аликсей Артёмович", 2);

        Console.WriteLine("Имя студента: " + student.Name);
        Console.WriteLine("Курс: " + student.Course);
    }
}
