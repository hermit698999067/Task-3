using System;

class Student
{
    public string Name { get; set; }
    public int Course { get; set; }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "Аликсей Артёмович";
        student.Course = 3;

        Console.WriteLine("Имя студента: " + student.Name);
        Console.WriteLine("Курс: " + student.Course);
    }
}
