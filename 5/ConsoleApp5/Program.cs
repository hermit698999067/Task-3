using System;

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
        Console.WriteLine("Имя студента: " + Name);
        Console.WriteLine("Курс: " + Course);
        Console.WriteLine("Форма обучения: " + Form);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Артём Алексеевич", 2, StudyForm.PartTime);

        student.PrintInfo();
    }
}
