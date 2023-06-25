using Domain.Models;
namespace Infrastructure.Services;

public class DepartmentService
{
    //Create
    List<Department> _departments;
    public DepartmentService()
    {
        _departments = new List<Department>();
    }

    //Read
    public List<Department> GetDepartment()
    {
        return _departments;
    }
    //Update
    public void AddDepartment(Department department)
    {
        _departments.Add(department);
    }

    public Department? UpdateDepartment(Department d)
    {
        foreach (var dep in _departments)
        {

            if (dep.Id == d.Id)
            {
                dep.Name = d.Name;
                dep.Description = d.Description;
                dep.Manager = d.Manager;
                return dep;
            }
        }
        return null;
    }
    public string DeleteDepartment(int id)
    {
        foreach (var d in _departments)
        {
            if (d.Id == id)
            {
                _departments.Remove(d);
                return "Department Delete successfuly";
            }
        }
        return "Department is not Found";
    }
    public int CountDepartment()
    {
        return _departments.Count;
    }

}
