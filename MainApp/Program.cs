using Domain.Models;
using Infrastructure.Services;

var empService = new EmployeeService();

// for (int i = 1; i <= 3; i++)
// {
//     System.Console.WriteLine($"Employee {i}");
//     var emp = new Employee();
//     System.Console.WriteLine("Enter Firstname");
//     emp.Firstname = Console.ReadLine();
//     System.Console.WriteLine("Enter Lastname");
//     emp.Lastname = Console.ReadLine();
//     System.Console.WriteLine("Enter Birthdate");
//     emp.BirthDate = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
//     System.Console.WriteLine("Enter Salary");
//     emp.Salary = Convert.ToDecimal(Console.ReadLine());
//     System.Console.WriteLine("Enter Department name");
//     emp.Department.Name = Console.ReadLine();
//     System.Console.WriteLine("Enter Department description");
//     emp.Department.Description = Console.ReadLine();

//     empService.AddEmployees(emp);
// }

// System.Console.WriteLine("Name          Surname          Salary          Birthdate          Departmen name");
// foreach (var emp in empService.GetEmployees())
// {
//     System.Console.WriteLine($"{emp.Firstname}          {emp.Lastname}        {emp.Salary}        {emp.BirthDate}        {emp.Department.Name}");
// }

var depService = new DepartmentService();
for (int i = 1; i <= 3; i++)
{
    System.Console.WriteLine($"Department {i}");
    var dep = new Department();
    dep.Id=i;
    System.Console.WriteLine();
    dep.Name = Console.ReadLine();
    System.Console.WriteLine();
    dep.Description = Console.ReadLine();
    System.Console.WriteLine();

    //dep.Manager.Lastname = Console.ReadLine();
    // dep.Manager.Firstname = Console.ReadLine();
    depService.AddDepartment(dep);
}
System.Console.WriteLine("Dep.Id     Dep. name      Discription       Manager");
foreach (var d in depService.GetDepartment())
{
    System.Console.WriteLine($"{d.Id}    {d.Name}      {d.Description}        ");
}