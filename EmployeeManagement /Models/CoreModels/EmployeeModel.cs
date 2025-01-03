using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeeManagement.Models.DTOModels;

namespace EmployeeManagement.Models.CoreModels;

[Table("Employee")]
public class EmployeeModel
{
    [Key] public long EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public decimal HourlyRate { get; set; }

    public void AssignObject(EmployeeModelDTO employee)
    {
        EmployeeId = long.Parse(employee.EmployeeId); //In production, this would be encrypted
        FirstName = employee.FirstName;
        LastName = employee.LastName;
        Phone = employee.Phone;
        Email = employee.Email;
        HourlyRate = employee.HourlyRate;
    }
}