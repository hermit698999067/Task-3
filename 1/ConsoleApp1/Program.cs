using System;

class Student
{
    public string Name;
    public int Course;
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "Аликсей Артёмович";
        student.Course = 2;

        Console.WriteLine("Имя студента: " + student.Name);
        Console.WriteLine("Курс: " + student.Course);
    }
}