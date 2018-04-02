using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    private List<Student> students;

    public School()
    {
        students = new List<Student>();
    }

    public void Add(string name, int grade)
    {
        students.Add(new Student(name, grade));
    }

    public IEnumerable<string> Roster()
    {
        return students
            .Select(s => s.Name)
            .OrderBy(n => n);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return students
            .Where(s => s.Grade == grade)
            .Select(s => s.Name)
            .OrderBy(n => n);
    }
}

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}