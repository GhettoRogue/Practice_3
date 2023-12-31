﻿using Practice_3;

var employees = new List<Employee>()
{
    new () { Id = 1, FullName = "Vladimir Ignatiew", Position = "Engineer", Department = "Development" },
    new () { Id = 2, FullName = "Mike Johnson", Position = "Manager", Department = "Sales" },
    new () { Id = 3, FullName = "John Smith", Position = "Accountant", Department = "Financial" }
};

var search = UserInput();
FindEmployees(search, employees);

return;

string UserInput()
{
    Console.Write("Enter ID, full name, position or department of employee: ");
    var str = Console.ReadLine()!;
    return str;
}

static void FindEmployees(string search, List<Employee> employees)
{
    var result = new List<Employee>();
    foreach (var item in employees)
    {
        if (item.Id.ToString() == search ||
            item.FullName.ToLower().Contains(search.ToLower()) ||
            item.Position == search ||
            item.Department == search)
        {
            result.Add(item);
        }

        if (result.Count > 0)
        {
            Console.WriteLine($"Found {result.Count} employee.");
            foreach (var employee in result)
            {
                Console.WriteLine(
                    $"ID: {employee.Id}," +
                    $" FullName: {employee.FullName}," +
                    $" Position: {employee.Position}," +
                    $" Department: {employee.Department}");
            }
        }

        Console.WriteLine("Employees not found.");
    }
}

/*  var result = employees.FindAll(
    temp =>
        temp.Id.ToString() == search ||
        temp.FullName.ToLower().Contains(search.ToLower()) ||
        temp.Position.ToString() == search ||
        temp.Department.ToString() == search);*/