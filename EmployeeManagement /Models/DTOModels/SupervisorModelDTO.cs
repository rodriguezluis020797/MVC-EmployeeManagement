using EmployeeManagement.Models.CoreModels;

namespace EmployeeManagement.Models.DTOModels;

public class SupervisorModelDTO
{
    public string SupervisorId { get; set; } = default;
    public string FirstName { get; set; } = default;
    public string LastName { get; set; } = default;
    public string FullName => $"{FirstName} {LastName}";
    public string Phone { get; set; } = default;
    public string Email { get; set; } = default;

    public void AssignObject(SupervisorModel supervisor)
    {
        SupervisorId = supervisor.SupervisorId.ToString(); //In production, this would be encrypted
        FirstName = supervisor.FirstName;
        LastName = supervisor.LastName;
        Phone = supervisor.Phone;
        Email = supervisor.Email;
    }
}