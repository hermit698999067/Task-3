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

    public void PrintInfo()
    {
        Console.WriteLine("Имя студента: " + Name);
        Console.WriteLine("Курс: " + Course);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Аликсей Артёмович", 3);

        student.PrintInfo();
    }
}
