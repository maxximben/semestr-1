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
using System.Linq;

class Program
{
    const int MaxStudents = 100;
    const int MaxTeachers = 100;

    static void Main(string[] args)
    {
        Student[] students = new Student[MaxStudents];
        Teacher[] teachers = new Teacher[MaxTeachers];
        int studentCount = 0;
        int teacherCount = 0;

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
                    studentCount = FillData(students, studentCount);
                    teacherCount = FillTeachersData(teachers, teacherCount);
                    break;
                case "2":
                    PrintData(students, studentCount, teachers, teacherCount);
                    break;
                case "3":
                    FilterStudentsByBirthYear(students, studentCount);
                    break;
                case "4":
                    FilterTeachersBySubject(teachers, teacherCount);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Давай ещё.");
                    break;
            }
        }
    }

    static int FillData(Student[] students, int studentCount)
    {
        while (studentCount < MaxStudents)
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
            students[studentCount++] = new Student(studentName, studentBirthYear, grades);
        }
        return studentCount;
    }

    static int FillTeachersData(Teacher[] teachers, int teacherCount)
    {
        while (teacherCount < MaxTeachers)
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
            teachers[teacherCount++] = new Teacher(teacherName, teacherBirthYear, subjects);
        }
        return teacherCount;
    }

    static void PrintData(Student[] students, int studentCount, Teacher[] teachers, int teacherCount)
    {
        Console.WriteLine("Студенты: ");
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine(students[i]);
        }

        Console.WriteLine("Преподаватели: ");
        for (int i = 0; i < teacherCount; i++)
        {
            Console.WriteLine(teachers[i]);
        }
    }

    static void FilterStudentsByBirthYear(Student[] students, int studentCount)
    {
        Console.Write("Введите год рождения для фильтрации студентов: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Студенты, родившиеся в " + year);
        for (int i = 0; i < studentCount; i++)
        {
            if (students[i].BirthYear == year)
            {
                Console.WriteLine(students[i]);
            }
        }
    }

    static void FilterTeachersBySubject(Teacher[] teachers, int teacherCount)
    {
        Console.Write("Введите название дисциплины для фильтрации преподавателей: ");
        string subject = Console.ReadLine();
        Console.WriteLine("Преподаватели, ведущие предмет " + subject + ":");
        for (int i = 0; i < teacherCount; i++)
        {
            if (teachers[i].Subjects.Contains(subject))
            {
                Console.WriteLine(teachers[i]);
            }
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
        return FullName + " Год рождения " + BirthYear + " Оценки " + string.Join(", ", Grades);
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
        return FullName + " Год рождения " + BirthYear + " Предметы " + string.Join(", ", Subjects);
    }
}
