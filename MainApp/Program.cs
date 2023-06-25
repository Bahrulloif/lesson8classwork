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




// Create
var depService = new DepartmentService();
for (int i = 1; i <= 3; i++)
{
    System.Console.WriteLine($"Department {i}");
    var dep = new Department();
    dep.Id = i;
    System.Console.WriteLine("Enter Department name");
    dep.Name = Console.ReadLine();
    System.Console.WriteLine("Enter Department Description");
    dep.Description = Console.ReadLine();
    System.Console.WriteLine("Enter Department Manager");

    dep.Manager = new Employee();
    System.Console.WriteLine("Lastname");
    dep.Manager.Lastname = Console.ReadLine();
    System.Console.WriteLine("Firstname");
    dep.Manager.Firstname = Console.ReadLine();
    depService.AddDepartment(dep);
}
// Read
System.Console.WriteLine("Dep.Id     Dep. name      Discription       Manager");
foreach (var d in depService.GetDepartment())
{
    System.Console.WriteLine($"{d.Id}    {d.Name}      {d.Description}        {d.Manager.Lastname}       {d.Manager.Firstname}");
}

// Update
var item = new Department();
item.Manager = new Employee(); //почему не var?

item.Id= Convert.ToInt32(Console.ReadLine());
item.Name = Console.ReadLine();
item.Description = Console.ReadLine();
item.Manager.Firstname = Console.ReadLine();
item.Manager.Lastname = Console.ReadLine();
depService.UpdateDepartment(item);

// Read
System.Console.WriteLine("Dep.Id     Dep. name      Discription       Manager");
foreach (var d in depService.GetDepartment())
{
    System.Console.WriteLine($"{d.Id}    {d.Name}      {d.Description}        {d.Manager.Lastname}       {d.Manager.Firstname}");
}

// Delete
System.Console.WriteLine("Enter ID for Delete");
int b=Convert.ToInt32(Console.ReadLine());
depService.DeleteDepartment(b);

// Read
System.Console.WriteLine("Dep.Id     Dep. name      Discription       Manager");
foreach (var d in depService.GetDepartment())
{
    System.Console.WriteLine($"{d.Id}    {d.Name}      {d.Description}        {d.Manager.Lastname}       {d.Manager.Firstname}");
}