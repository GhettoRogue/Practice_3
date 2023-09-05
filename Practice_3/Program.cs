using Practice_3;

var employees = new List<Employee>()
{
    new Employee() { Id = 1, FullName = "Vladimir Ignatiew", Position = "Engineer", Department = "Development" },
    new Employee() { Id = 2, FullName = "Mike Smith", Position = "Manager", Department = "Sales" },
    new Employee() { Id = 3, FullName = "John Smith", Position = "Accountant", Department = "Financial" }
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
    var result = employees.FindAll(
        temp =>
            temp.Id.ToString() == search ||
            temp.FullName.ToLower().Contains(search.ToLower()) ||
            temp.Position.ToString() == search ||
            temp.Department.ToString() == search);

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

/*/*foreach (var employee in employees)
{
    if (employee.Id.ToString() == search ||
        employee.FullName.ToLower().Contains(search.ToLower()) ||
        employee.Position.ToString() == search ||
        employee.Department.ToString() == search)
    {
        result.Add(employee);
    }
}*/
