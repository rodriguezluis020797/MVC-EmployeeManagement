using EmployeeManagement.Models.CoreModels;

namespace EmployeeManagement.Services;

public interface ISupervisorService
{
    public SupervisorModel GetSupervisor();
}

public class SupervisorService : ISupervisorService
{
    public SupervisorModel GetSupervisor()
    {
        return new SupervisorModel
        {
            SupervisorId = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@gmail.com",
            Phone = "1234567890"
        };
    }
}