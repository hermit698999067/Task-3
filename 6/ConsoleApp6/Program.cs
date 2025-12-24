using System;

enum StudyForm
{
    FullTime,
    PartTime
}

class Student
{
    // Статическое поле — общее количество студентов
    public static int TotalStudents = 0;

    public string Name { get; set; }
    public int Course { get; set; }
    public StudyForm Form { get; set; }

    // Конструктор
    public Student(string name, int course, StudyForm form)
    {
        Name = name;
        Course = course;
        Form = form;

        // Увеличиваем счётчик при создании объекта
        TotalStudents++;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Имя студента: " + Name);
        Console.WriteLine("Курс: " + Course);
        Console.WriteLine("Форма обучения: " + Form);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Гордон Фриман", 1, StudyForm.FullTime);
        Student s2 = new Student("Алекс Венс", 2, StudyForm.PartTime);
        Student s3 = new Student("Джудит Моссман", 3, StudyForm.FullTime);

        s1.PrintInfo();
        s2.PrintInfo();
        s3.PrintInfo();

        // Вывод общего количества студентов
        Console.WriteLine("Общее количество студентов: " + Student.TotalStudents);
    }
}
