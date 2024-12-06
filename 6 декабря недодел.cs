using System;

class Student
{
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public int Course { get; set; }

    public override string ToString()
    {
        return "Фамилия: " + LastName + " Год рождения: " + BirthYear + " Курс: " + Course; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = null;
        int studentCount = 0;

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Заполнение");
            Console.WriteLine("2. Модификация");
            Console.WriteLine("3. Первая выборка (по году рождения)");
            Console.WriteLine("4. Вторая выборка (по курсу)");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите количество студентов: ");
                    studentCount = int.Parse(Console.ReadLine());
                    students = new Student[studentCount];

                    for (int i = 0; i < studentCount; i++)
                    {
                        students[i] = new Student();
                        Console.Write("Введите фамилию: ");
                        students[i].LastName = Console.ReadLine();
                        Console.Write("Введите год рождения: ");
                        students[i].BirthYear = int.Parse(Console.ReadLine());
                        Console.Write("Введите курс: ");
                        students[i].Course = int.Parse(Console.ReadLine());
                    }
                    break;

                case "2":
                    if (students == null || students.Length == 0)
                    {
                        Console.WriteLine("Список студентов пуст. Сначала заполните его.");
                        break;
                    }

                    Console.Write("Введите фамилию студента для модификации: ");
                    string lastNameToModify = Console.ReadLine();
                    Student studentToModify = Array.Find(students, s => s.LastName.Equals(lastNameToModify, StringComparison.OrdinalIgnoreCase));

                    if (studentToModify == null)
                    {
                        Console.WriteLine("Студент с такой фамилией не найден.");
                        break;
                    }

                    Console.Write("Введите новую фамилию: ");
                    studentToModify.LastName = Console.ReadLine();
                    Console.Write("Введите новый год рождения: ");
                    studentToModify.BirthYear = int.Parse(Console.ReadLine());
                    Console.Write("Введите новый курс: ");
                    studentToModify.Course = int.Parse(Console.ReadLine());
                    break;

                case "3":
                    if (students == null || students.Length == 0)
                    {
                        Console.WriteLine("Список студентов пуст.");
                        break;
                    }

                    Console.Write("Введите год рождения для выборки: ");
                    int birthYear = int.Parse(Console.ReadLine());
                    Console.WriteLine("Студенты, родившиеся в {0}:", birthYear);
                    foreach (var student in students)
                    {
                        if (student.BirthYear == birthYear)
                        {
                            Console.WriteLine(student);
                        }
                    }
                    break;

                case "4":
                    if (students == null || students.Length == 0)
                    {
                        Console.WriteLine("Список студентов пуст.");
                        break;
                    }

                    Console.Write("Введите курс для выборки: ");
                    int course = int.Parse(Console.ReadLine());
                    Console.WriteLine("Студенты на курсе {0}:", course);
                    foreach (var student in students)
                    {
                        if (student.Course == course)
                        {
                            Console.WriteLine(student);
                        }
                    }
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}
