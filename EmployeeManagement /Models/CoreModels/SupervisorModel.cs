using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeeManagement.Models.DTOModels;

namespace EmployeeManagement.Models.CoreModels;

[Table("Supervisor")]
public class SupervisorModel
{
    [Key] public long SupervisorId { get; set; } = default;
    public string FirstName { get; set; } = default;
    public string LastName { get; set; } = default;
    public string Phone { get; set; } = default;
    public string Email { get; set; } = default;

    public void AssignObject(SupervisorModelDTO supervisor)
    {
        SupervisorId = long.Parse(supervisor.SupervisorId); //In production, this would be decrypted
        FirstName = supervisor.FirstName;
        LastName = supervisor.LastName;
        Phone = supervisor.Phone;
        Email = supervisor.Email;
    }
}