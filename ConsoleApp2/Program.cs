using System;
using System.Collections.Generic;

public struct Student
{
    public string FullName;
    public string EarOld;
    public int Height;
    public int Weight;
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>();

        Console.Write("Введите количество студентов: ");
        int studentCount = int.Parse(Console.ReadLine());
        //BOBER

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"Введите данные для студента {i + 1}:");

            Student student = new Student();

            Console.Write("ФИО: ");
            student.FullName = Console.ReadLine();

            Console.Write("Год ражнения: ");
            student.EarOld = Console.ReadLine();

            Console.Write("Рос: ");
            student.Height = Console.ReadLine();

            Console.Write("Вес: ");
            student.Weight = int.Parse(Console.ReadLine());

            students.Add(student);
        }

        // Выводим исходный массив на экран
        Console.WriteLine("\nИсходный массив:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.FullName}, {student.EarOld}, {student.Height}, {student.Weight}");
        }

        // Удаляем из массива студентов с рейтингом меньше заданного
        Console.Write("\nВведите вес для удаления студентов: ");
        int delv = int.Parse(Console.ReadLine());
        Console.Write("\nВведите рост для удаления студентов: ");
        int delr = int.Parse(Console.ReadLine());
        students.RemoveAll(s => s.Weight == delv && s.Height == delr);

        // Добавляем нового студента на заданную позицию
        Console.Write("\nВведите позицию для добавления нового студента: ");
        int position = int.Parse(Console.ReadLine()) - 1; // Нумерация начинается с 0

        Student newStudent = new Student();

        Console.WriteLine("\nВведите данные для нового студента:");

        Console.Write("ФИО: ");
        newStudent.FullName = Console.ReadLine();

        Console.Write("Год раждения: ");
        newStudent.EarOld = Console.ReadLine();

        Console.Write("Рост: ");
        newStudent.Height = Console.ReadLine();

        Console.Write("вес:");
        newStudent.Weight = int.Parse(Console.ReadLine());

        students.Insert(position, newStudent);

        // Выводим измененный массив на экран
        Console.WriteLine("\nИзмененный массив:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.FullName}, {student.EarOld}, {student.Height}, {student.Weight}");
        }
    }
}
