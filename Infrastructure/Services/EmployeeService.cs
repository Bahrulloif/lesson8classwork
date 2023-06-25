using Domain.Models;
namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee>? _emploeyees;
    public EmployeeService()
    {
        _emploeyees = new List<Employee>();
    }
    public List<Employee> GetEmployees()
    {
        return _emploeyees;
    }
    public void AddEmployees(Employee employee)
    {
        employee.Id = _emploeyees.Count + 1;
        _emploeyees.Add(employee);
    }
    public int CountEmployees()
    {
        return _emploeyees.Count;
    }
    public Employee UpdateEmployee(Employee employee)
    {
        foreach (var e in _emploeyees)
        {
            if (e.Id == employee.Id)
            {
                e.Firstname = employee.Firstname;
                e.Lastname = employee.Lastname;
                e.BirthDate = employee.BirthDate;
                e.Salary = employee.Salary;
                e.Department.Name = employee.Department.Name;
                e.Department.Description = employee.Department.Description;

                return e;
            }
        }
        return null;
    }

    public string DeleteEmployee(int id)
    {
        foreach (var employee in _emploeyees)
        {
            if (employee.Id == id)
            {
                _emploeyees.Remove(employee);
                return "Employee deleted successfuly";
            }
        }
        return "Employee not found";
    }

}