using System;
using System.Collections.Generic;
using System.Linq;

class Teacher
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public decimal Salary { get; set; }

    public Teacher(string name, string subject, decimal salary)
    {
        Name = name;
        Subject = subject;
        Salary = salary;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name}, предмет: {Subject}, зарплата: {Salary}");
    }
}

class Department
{
    public string Name { get; set; }
    public List<Teacher> Teachers { get; set; } = new List<Teacher>();

    public Department(string name)
    {
        Name = name;
    }

    public void AddTeacher(Teacher t)
    {
        Teachers.Add(t);
    }

    public decimal GetAverageSalary()
    {
        if (Teachers.Count == 0) return 0;
        return Teachers.Average(t => t.Salary);
    }

    public void PrintTeachers()
    {
        Console.WriteLine($"Кафедра: {Name}");
        foreach (var t in Teachers)
        {
            t.PrintInfo();
        }
        Console.WriteLine($"Средняя зарплата кафедры: {GetAverageSalary():F2}\n");
    }
}

class University
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; } = new List<Department>();

    public University(string name)
    {
        Name = name;
    }

    public void AddDepartment(Department d)
    {
        Departments.Add(d);
    }

    public int GetTotalTeachers()
    {
        return Departments.Sum(d => d.Teachers.Count);
    }

    public Teacher GetHighestPaidTeacher()
    {
        return Departments
            .SelectMany(d => d.Teachers)
            .OrderByDescending(t => t.Salary)
            .FirstOrDefault();
    }

    public void PrintUniversityInfo()
    {
        Console.WriteLine($"Университет: {Name}");
        Console.WriteLine($"Общее количество преподавателей: {GetTotalTeachers()}\n");

        foreach (var dept in Departments)
        {
            dept.PrintTeachers();
        }

        Teacher topTeacher = GetHighestPaidTeacher();
        if (topTeacher != null)
        {
            Console.WriteLine($"Самый высокооплачиваемый преподаватель: {topTeacher.Name}, зарплата: {topTeacher.Salary}");
        }
    }
}

class Program
{
    static void Main()
    {
        University uni = new University("Нур-Султанский университет");

        Department mathDept = new Department("Математика");
        mathDept.AddTeacher(new Teacher("Гордон Фримен", "Алгебра", 50000));
        mathDept.AddTeacher(new Teacher("Алекс Венс", "Геометрия", 60000));

        Department physicsDept = new Department("Физика");
        physicsDept.AddTeacher(new Teacher("Джудит Моссман", "Механика", 70000));
        physicsDept.AddTeacher(new Teacher("Айзик Кляйнер", "Термодинамика", 65000));

        uni.AddDepartment(mathDept);
        uni.AddDepartment(physicsDept);

        uni.PrintUniversityInfo();
    }
}
