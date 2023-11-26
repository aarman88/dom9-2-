using System;

public class Employee
{
    private string name;
    private int age;
    private double salary;

    public Employee(string name, int age, double salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Зарплата: {salary}");
    }

    public virtual double CalculateAnnualSalary()
    {
        return salary * 12;
    }
}

public class Manager : Employee
{
    private double bonus;

    public Manager(string name, int age, double salary, double bonus)
        : base(name, age, salary)
    {
        this.bonus = bonus;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Бонус: {bonus}");
    }

    public override double CalculateAnnualSalary()
    {
        return base.CalculateAnnualSalary() + bonus;
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager("Alice Smith", 35, 80000, 5000);
        manager.GetInfo();
        double annualSalary = manager.CalculateAnnualSalary();
        Console.WriteLine($"Годовая зарплата: {annualSalary}");
    }
}
