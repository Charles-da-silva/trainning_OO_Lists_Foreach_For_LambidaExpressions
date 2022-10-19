using Projeto2;

List<Employee> employee = new List<Employee>();

Console.Write("How many employees will be registered? ");
int Count = int.Parse(Console.ReadLine());
int Id = 0;
string Name = "a";
double Salary = 0.0;

for (int i = 0; i < Count; i++)
{
    System.Console.WriteLine($"Employee #{i + 1}:");
    System.Console.Write("Id: ");
    Id = int.Parse(Console.ReadLine());
    System.Console.Write("Name: ");
    Name = Console.ReadLine();
    System.Console.Write("Salary: ");

    employee.Add(new Employee(Id, Name, Salary));

    System.Console.WriteLine();
}

System.Console.Write("Enter the employee id that will have salary increase: ");
Id = int.Parse(Console.ReadLine());
double percentage = 0.0;
System.Console.Write("Enter the percentage: ");
percentage = double.Parse(Console.ReadLine());

int indexEmployee = employee.FindIndex(x => x.Id == Id);

employee[indexEmployee].increaseSalary(percentage);

System.Console.WriteLine();
System.Console.WriteLine("Updated list of employees: ");

foreach (object item in employee)
{
    System.Console.WriteLine(item);
}





