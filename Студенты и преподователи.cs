/*
 Класс люди 
 * Характеризуктся полями ФИО, год рождения
 * Два наследника класса
 * Класс студенты, характеризуется массивом оценок
 * Класс преподователи, предметы
 * Меню 
 * заполнение
 * печать данных
 * Выборка студентов по году
 * Выборка преподоватклей по дисциплине
 * выход
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Заполнение данных");
            Console.WriteLine("2. Печать данных");
            Console.WriteLine("3. Выборка студентов по году рождения");
            Console.WriteLine("4. Выборка преподавателей по наименованию дисциплины");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите опцию: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FillData(students, teachers);
                    break;
                case "2":
                    PrintData(students, teachers);
                    break;
                case "3":
                    FilterStudentsByBirthYear(students);
                    break;
                case "4":
                    FilterTeachersBySubject(teachers);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Давай ещё.");
                    break;
            }
        }
    }

    static void FillData(List<Student> students, List<Teacher> teachers)
    {
        while (true)
        {
            Console.WriteLine("Введите данные для студента (или нажмите Enter для завершения):");
            Console.Write("ФИО: ");
            string studentName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(studentName)) break;

            Console.Write("Год рождения: ");
            int studentBirthYear = int.Parse(Console.ReadLine());
            Console.Write("Количество оценок: ");
            int gradesCount = int.Parse(Console.ReadLine());
            int[] grades = new int[gradesCount];
            for (int i = 0; i < gradesCount; i++)
            {
                Console.WriteLine(" Оценка " + (i + 1));
                grades[i] = int.Parse(Console.ReadLine());
            }
            students.Add(new Student(studentName, studentBirthYear, grades));
        }



        while (true)
        {
            Console.WriteLine("Введите данные для преподавателя (или нажмите Enter для завершения):");
            Console.Write("ФИО: ");
            string teacherName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(teacherName)) break;

            Console.Write("Год рождения: ");
            int teacherBirthYear = int.Parse(Console.ReadLine());
            Console.Write("Предметы (через запятую): ");
            string subjectsInput = Console.ReadLine();
            string[] subjects = subjectsInput.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
            teachers.Add(new Teacher(teacherName, teacherBirthYear, subjects));
        }
    }



    static void PrintData(List<Student> students, List<Teacher> teachers)
    {
        Console.WriteLine("Студенты: ");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("Преподаватели: ");
        foreach (var teacher in teachers)
        {
            Console.WriteLine(teacher);
        }
    }



    static void FilterStudentsByBirthYear(List<Student> students)
    {
        Console.Write("Введите год рождения для фильтрации студентов: ");
        int year = int.Parse(Console.ReadLine());
        var filteredStudents = students.Where(s => s.BirthYear == year).ToList();

        Console.WriteLine("Студенты, родившиеся в " + year);
        foreach (var student in filteredStudents)
        {
            Console.WriteLine(student);
        }
    }



    static void FilterTeachersBySubject(List<Teacher> teachers)
    {
        Console.Write("Введите название дисциплины для фильтрации преподавателей: ");
        string subject = Console.ReadLine();
        var filteredTeachers = teachers.Where(t => t.Subjects.Contains(subject)).ToList();

        Console.WriteLine("Препедователи, ведуцие предмет " + subject + ":");
        foreach (var teacher in filteredTeachers)
        {
            Console.WriteLine(teacher);
        }
    }
}

class People
{
    public string FullName { get; set; }
    public int BirthYear { get; set; }

    public People(string fullName, int birthYear)
    {
        FullName = fullName;
        BirthYear = birthYear;
    }
}



class Student : People
{
    public int[] Grades { get; set; }

    public Student(string fullName, int birthYear, int[] grades) : base(fullName, birthYear)
    {
        Grades = grades;
    }

    public override string ToString()
    {
        return FullName + " Год рождения " +  BirthYear + " Оценки " + string.Join(", ", Grades);
    }
}



class Teacher : People
{
    public string[] Subjects { get; set; }

    public Teacher(string fullName, int birthYear, string[] subjects) : base(fullName, birthYear)
    {
        Subjects = subjects;
    }

    public override string ToString()
    {
        return FullName + " Год рождения " +  BirthYear + " Предметы " + string.Join(", ", Subjects);
    }
}
