using System;

public class EmployeeData
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int employeeId = int.Parse(Console.ReadLine());
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Employee ID: " + employeeId.ToString("D8"));
        Console.WriteLine("Salary: " + salary.ToString("F"));
    }
}