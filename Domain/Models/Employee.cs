namespace Domain.Models;

public class Employee
{
    public int Id;
    public string? Firstname;
    public string? Lastname;
    public DateTime BirthDate;
    public decimal Salary;
    public Department? Department;
    
}
