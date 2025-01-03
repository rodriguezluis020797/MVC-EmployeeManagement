using EmployeeManagement.Models.CoreModels;

namespace EmployeeManagement.Services;

public interface IEmployeeService
{
    public List<EmployeeModel> GetEmployees();
}

public class EmployeeService : IEmployeeService
{
    public List<EmployeeModel> GetEmployees()
    {
        var employees = new List<EmployeeModel>
        {
            new()
            {
                FirstName = "Jane",
                LastName = "Doe",
                Email = "jane.doe@gmail.com",
                Phone = "1234567890",
                EmployeeId = 1,
                HourlyRate = 20.00m
            },
            new()
            {
                FirstName = "Jane",
                LastName = "Doe",
                Email = "jane.doe@gmail.com",
                Phone = "1234567890",
                EmployeeId = 2,
                HourlyRate = 23.00m
            }
        };

        return employees;
    }
}