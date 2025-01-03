using EmployeeManagement.Models.CoreModels;

namespace EmployeeManagement.Models.DTOModels;

public class EmployeeModelDTO
{
    public string EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public string Phone { get; set; }
    public string Email { get; set; }
    public decimal HourlyRate { get; set; }

    public void AssignObject(EmployeeModel employee)
    {
        EmployeeId = employee.EmployeeId.ToString(); //In production, this would be encrypted
        FirstName = employee.FirstName;
        LastName = employee.LastName;
        Phone = employee.Phone;
        Email = employee.Email;
        HourlyRate = employee.HourlyRate;
    }
}